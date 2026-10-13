namespace DataLoggingF26
{
    public partial class DataLoggingF26Form : Form
    {
        public DataLoggingF26Form()
        {
            InitializeComponent();
        }


        void DrawLine(int x, int y)
        {
            Graphics g = DisplayPictureBox.CreateGraphics();    //Where am I drawing
            Pen thePen = new Pen(Color.Green);                  //What am I drawing with
            float sx = DisplayPictureBox.Width / 100f;
            float sy = DisplayPictureBox.Height / 1024f;
            
            g.ScaleTransform(sx,-sy);        //Set scale of display reguarless of pixels and fix y direction
            g.TranslateTransform(0,-1024);   //Move drawing origin to bottom left


            g.DrawLine(thePen, 0, 0, x, y);

            //free these resources
            g.Dispose();        //Done with this
            thePen.Dispose();   //Done with this
        }



        //-----------------------------------------------------------------------------------------
        //
        //Event Handlers Below---------------------------------------------------------------------
        //
        //-----------------------------------------------------------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            DrawLine(100,1024);
        }
    }
}
