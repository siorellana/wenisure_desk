﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
namespace FacialRecognition
{
    public partial class ModEnroll : Form
    {
        Capture grabber;
        Image<Bgr, byte> currentFrame;
        Image<Gray, byte> gray,result,TrainedFace = null;
        // Inicializa haarcascade
        HaarCascade face;
        //initialize faces and name storage array
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        int NumLabels,ContTrain=0;
        int t = 0;
        DateTime horadetectada = DateTime.Now;

        // Variables para guardar en base de datos
        String nombre = null;
        String rut = null;
        String fechaRegistro = null;
        String perfil = null;
        String fecha = null;
        

        public ModEnroll()
        {
            //load cascade file by giving file name
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            
            InitializeComponent();
            try
            {
                //Load of previus trainned faces and labels for each image
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                string[] Labels = Labelsinfo.Split('%');
                NumLabels = Convert.ToInt16(Labels[0]);//total no. of faces present
                ContTrain = NumLabels;//cont train will add new image to previous 1 i.e if 3 are present new added give it as4
                string LoadFaces;

                for (int tf = 1; tf < NumLabels + 1; tf++)
                {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                    labels.Add(Labels[tf]);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("ATENCION! No hay personas registradas. Entrene unas antes de activar la detección.");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDetectCam.Visible = false;
            btnIngresar.Visible = false;
            boxPerfil.Visible = false;
        }

        private void btnStartCam_Click(object sender, EventArgs e)
        {
            grabber = new Capture();
            // initialize grabber event
            grabber.QueryFrame();
            // capture video 
            Application.Idle += new EventHandler(FrameGrabber);
            //initalize Frame grabber event
            btnDetectCam.Visible = true;
            btnStartCam.Visible = false;
        }
        void FrameGrabber(object sender, EventArgs e)
        {

            currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            //convert frame to gray scale
            gray = currentFrame.Convert<Gray, Byte>();
            //now detect face by using classifier
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
            face,//name of cascade
            1.2,
            10,
            Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
            new Size(20, 20));
            //now check each frame of imagebox containing video and detect face
            foreach (MCvAvgComp f in facesDetected[0])
            {
                //if face found increment t
                t = t + 1;
                //now see result by copying detected face in a frame name as result
                result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                //we convert current frame to gray scale and resize to 100x100
                //now draw rectangle on detected image
                currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);

            }

            //view currentframe in imported imagebox
            imageBox1.Image = currentFrame;
        }

        private void imageBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDetectCam_Click(object sender, EventArgs e)
        {
            try
            {
                lblNombre.Visible = true;
                txtNombre.Visible = true;
                lblRut.Visible = true;
                txtRut.Visible = true;
                lblHora.Visible = true;
                lblPerfil.Visible = true;
                boxPerfil.Visible = true;
                btnIngresar.Visible = true;
                //use image box to show the detected face
                //go to design view and create
                //as we already detect face in previous lecturee and store in result
                //we use that and resize in new gray image
                TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                //now show in imagebox
                imageBox2.Image = TrainedFace;

                lblHora.Text = horadetectada.ToString();
                //run
                //as you see image detected and resized
                //now we will save image along with its name so
                btnDetectCam.Visible = false;

            }
            catch (System.Exception ex)
            {

                lblMensaje.Text = "No se detecto ninguna Persona";
                MessageBox.Show("No se detecto ninguna Persona");

                MessageBox.Show(ex.Message, "No se detecto ninguna Persona");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ModMenu s = new ModMenu();
            s.Show();
            this.Hide();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ContTrain = ContTrain + 1;

            trainingImages.Add(TrainedFace);

            // Variables para guardar en archivo
            nombre = txtNombre.Text;
            rut = txtRut.Text;
            fecha = fechaRegistro;
            perfil = boxPerfil.Text;
            byte[] arr = null;

            // Agregar los campos al archivo Labels.txt
            labels.Add(nombre + "-" + rut + "-" + perfil);

            //write no. of trained faces to list
            File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");//add library to read/write to input file
            
            //write labels or data name to file
            for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
            {
                trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp");//sav faces to folder with name face(i)i is no. of face and .bmp extension of detected face image
                File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()[i - 1] + "%");//save names to text file
                Image fotoGuardada = Image.FromFile(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp"); // Se le indica la ruta de la imagen
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(fotoGuardada, typeof(byte[]));
            }
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            MessageBox.Show("Se ha guardado imagen en base de datos.");
            //now load previous images and append new trainining image to it
            //now run
            ModMenu s = new ModMenu();
            s.Show();
            this.Hide();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblNombre.Visible = true;
            txtNombre.Visible = true;
            btnIngresar.Visible = true;
            //done
            //use image box to show the detected face
            //go to design view and create
            //as we already detect face in previous lecturee and store in result
            //we use that and resize in new gray image
            TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            //now show in imagebox
            imageBox2.Image = TrainedFace;
            //run
            //as you see image detected and resized
            //now we will save image along with its name so

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ContTrain=ContTrain+1;
            //now save the trained images
            //so we create a folder to save image database
            //Go to yours project debug folder and create folder
            //name it with TrainedFaces or any thing you want
            //in this folder detected faces will be save
            //now we need to save name of specific image as well
            //we will create a text file inside same folder
            //name it as TrainedLabels.txt or any thing you want
            //Done now we will do coding work
            //So save face detected in folder Trainedface created in previous tutorial
            //save name to face from textbox to text file
            //so create list array to save database
            //now load 
            //add images and names to list array
            trainingImages.Add(TrainedFace);
            labels.Add(txtNombre.Text);
            //write no. of trained faces to list
            File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");//add library to read/write to input file
            //write labels or data name to file
            for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
            {
                trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp");//sav faces to folder with name face(i)i is no. of face and .bmp extension of detected face image
                File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()[i - 1] + "%");//save names to text file
            }
            MessageBox.Show("Image trained and save to database");
            //now load previous images and append new trainining image to it
            //now run
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModMenu s = new ModMenu();
            s.Show();
            this.Hide();
        }

       
       

       

       
       

       
       

       

        

        
        
       
    }
}
