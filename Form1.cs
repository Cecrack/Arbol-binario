namespace arbol2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Nodo aP=new Nodo();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        public void arbol(Nodo ap)
        {
            string set = Microsoft.VisualBasic.Interaction.InputBox("Agregar dato", " ", "Dato"); 
            ap.info = set;
            if (aP == null)
            {
                aP= ap;
            }
            DialogResult Resp1, Resp2; // comando de respuesta para el messagebutton//
            Resp1 = MessageBox.Show("Quieres nodo por la izquierda?----(si o no)", " ", MessageBoxButtons.YesNo); // comando para mandar un cuadro de pregunta para mover el nodo a la izquierda  //
            if (Resp1 == DialogResult.Yes)
            {
                Nodo g = new Nodo(); //creacion del nodo hacia la izquierda (arbol)//
                ap.left = g;
                arbol(g);
            }
            else
            {
                ap.left = null; //se acaba el recorrido por la izquierda//
            }
            
            Resp2 = MessageBox.Show("Quieres nodo por la derecha?----( si-- no)", " ", MessageBoxButtons.YesNo);// lo mismo de la linea 24 pero a la derecha  //

            if (Resp2 == DialogResult.Yes)
            {
                Nodo h = new Nodo();     // creacion del nodo hacia la derecha(arbol)//
                ap.right = h;
                arbol(h);
            }
            else
            {
                ap.right = null; //se acaba el recorrido por la derecha//
            }
        }
        public void Preorden(Nodo ap)
        {
            if (ap != null)
            {
                lsarbol.Items.Add(ap.info);               
                Preorden(ap.left);              // creacion del codigo preorden mediante la recursividad//
                Preorden(ap.right);
            }
        }
        public void Inorden(Nodo ap)
        {

            if (ap != null)
            {

                Inorden(ap.left);
                lsarbol.Items.Add(ap.info);    // creacion del codigo inorden mediante la recursividad//
                Inorden(ap.right);
            }
        }

        public void posole(Nodo ap)
        {
            if (ap != null)
            {

                posole(ap.left);
                posole(ap.right);             // creacion del codigo posorden mediante la recursividad//
                lsarbol.Items.Add(ap.info);
            }



        }

        private void btnag_Click(object sender, EventArgs e)
        {
            arbol(aP);        //llamar a la funcion arbol//
        }

        private void btnpre_Click(object sender, EventArgs e)
        {
            lsarbol.Items.Clear(); //el clear, valla lo limpia :v//
            Preorden(aP);   //llmama la funcion preorden//
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            lsarbol.Items.Clear();
            Inorden(aP);  //llmama la funcion inorden//

        }

        private void btnpos_Click(object sender, EventArgs e)
        {
            lsarbol.Items.Clear();  
            posole(aP);   //llmama la funcion posorde//
        }

       
    }
    public class Nodo
    {
        public string info;
        public Nodo left;     //las clases creadas/
        public Nodo right; 
    }
    
    
}