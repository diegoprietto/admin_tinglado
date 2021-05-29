using System;
using System.Windows.Forms;
using Admin_Tinglado.Repository;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Admin_Tinglado
{
    public partial class Form1 : Form
    {
        readonly ITingladoRepository _tingladoRepository;

        public Form1()
        {
            InitializeComponent();

            _tingladoRepository = new TingladoRepository(Configuration.Configuration.GetMongoClient());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string pepe = Environment.GetEnvironmentVariable("AdminTingladoMongo");


            ////TEst
            var client = new MongoClient(
                pepe
            );
            var database = client.GetDatabase("tinglado");

            var collection = database.GetCollection<BsonDocument>("Users");

            var document = collection.Find(new BsonDocument()).FirstOrDefault();

            textBox1.Text = document.ToString();
        }
    }
}
