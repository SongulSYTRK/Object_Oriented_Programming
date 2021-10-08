using Genres_Movie_RepositoryExample.Entities.Concrete;
using Genres_Movie_RepositoryExample.Repositories.ConcreteRepositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genres_Movie_RepositoryExample
{
    public partial class Form1 : Form
    {
        ConcreteGenres RepoGenre = new ConcreteGenres();
        ConcreteMovie RepoMovie = new ConcreteMovie();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = RepoGenre.GetGenres();
            dataGridView2.DataSource = RepoMovie.GetMovie();
        }
        #region Genre 
        private void btnUpdateGenre_Click(object sender, EventArgs e)
        {
            Genres updateGenre = new Genres();
            updateGenre.Id = int.Parse(txtId.Text);
            updateGenre.Name = txtname.Text;
            updateGenre.Description = txtdescription.Text;
            RepoGenre.UpdateGenres(updateGenre);
            dataGridView1.DataSource = RepoGenre.GetGenres();
            Utility.Eraser(grpGenreUpdate);

        }

       

        private void btnCreateGenres_Click(object sender, EventArgs e)
        {
            Genres creategenre = new Genres(); // Genres tipi instance oluşturduk 

            creategenre.Id = int.Parse(txtGenresCreateId.Text);
            creategenre.Name = txtGenresCreatName.Text;
            creategenre.Description = txtGenresCreateDescription.Text;
            RepoGenre.CreateGenres(creategenre); // genre tipi değer almaktadır . bu yüzden bir genre tipi instance oluşturdum. Değerleri içine atarak burada değerleri gösterdik 
            dataGridView1.DataSource = RepoGenre.GetGenres();
            Utility.Eraser(grpGenresCreate);

        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
           
            
            RepoGenre.DeleteGenres(int.Parse(txtDeleteId.Text));
            dataGridView1.DataSource = RepoGenre.GetGenres();

        }
        #endregion

        #region Movie 
        private void btnupdateMovie_Click(object sender, EventArgs e)
        {
            Movie updatemovie = new Movie();
            Genres Moviegenre = new Genres();
            updatemovie.Id = int.Parse(txtUpdateMovieId.Text);
            updatemovie.Title = txtUpdateMovieTitle.Text;
            updatemovie.Content = txtUpdateMovieContent.Text;
            updatemovie.genre = Moviegenre;
            RepoMovie.UpdateMovie(updatemovie);
            dataGridView2.DataSource = RepoMovie.GetMovie();
            Utility.Eraser(grpMovieUpdate);

        }

        private void btnmovieCreate_Click(object sender, EventArgs e)
        {
            Movie CreateMovie = new Movie();
            Genres Moviecreategenre = new Genres();
            CreateMovie.Id = int.Parse(txtMovieCreateId.Text);
            CreateMovie.Title = txtMovieCreateTitle.Text;
            CreateMovie.Content = txtMovieCreateContent.Text;
            CreateMovie.genre = Moviecreategenre;
            RepoMovie.CreateMovie(CreateMovie);
            dataGridView2.DataSource = RepoMovie.GetMovie();
            Utility.Eraser(grpMovieCreate);
        }
        #endregion
    }
} 
 