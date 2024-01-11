using System.Linq;

namespace wfaSearchCity
{
    public partial class Form1 : Form
    {
        private string[] cities;

        public Form1()
        {
            InitializeComponent();

            cities = Properties.Resources.goroda.Split('\n');
            edSearch.TextChanged += edSearch_TextChanged;
        }

        private void edSearch_TextChanged(object? sender, EventArgs e)
        {
            //this.Text = $"{Application.ProductName} : {edSearch.Text}";

            var r = cities.Where(v => v.ToUpper().Contains(edSearch.Text.ToUpper()))
                .OrderBy(v => v)
                .ToArray();

            edResult.Text = string.Join(Environment.NewLine, r);
            this.Text = $"{Application.ProductName} : count={r.Count()}";
        }
    }
}