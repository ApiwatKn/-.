using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace โปรแกรมบันทึกข้อมูลนศ_
{
    public partial class Form1 : Form
    {
        List<Student> StudentsList = new List<Student>();
        List<double> GradeList = new List<double>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.textBoxname.Text;
            string student = this.textBoxID.Text;
            string Year = this.textBoxyear.Text;
            string Height = this.textBoxheight.Text;
            double grade = double.Parse(this.textBoxGrade.Text);
            string major = this.textBoxMajor.Text;

            Student Student = new Student(name, student, Year, Height, grade, major);
            StudentsList.Add(Student);


            BindingSource source = new BindingSource();
            source.DataSource = StudentsList;
            this.dataGridView1.DataSource = source;

            foreach (var val in StudentsList)
            {
                this.GradeList.Add(val.Grade);

            }
            double Maxgrade = GradeList.Max();
            double Mingrade = GradeList.Min();

            int allperson = StudentsList.Count();

            this.label10.Text = allperson.ToString();
            this.label11.Text = Maxgrade.ToString();
            this.label12.Text = Mingrade.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}