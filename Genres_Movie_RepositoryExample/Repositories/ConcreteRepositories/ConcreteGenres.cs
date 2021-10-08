using Genres_Movie_RepositoryExample.Entities.Concrete;
using Genres_Movie_RepositoryExample.Repositories.AbstractRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genres_Movie_RepositoryExample.Repositories.ConcreteRepositories
{
    public class ConcreteGenres : BaseGenresRepositories
    {
       
        public override Genres CreateGenres(Genres genre)
        {

            FakeDate.genre.Add(genre);   //Datamıza genres tipinde genre eklemesi gerçekleşti.
            return genre;
        }
        
        public override void DeleteGenres(int Id )
        {
            foreach ( Genres genre  in FakeDate.genre) //FakeData içersinde Genres tipinde  genre genre dolaşıyoruz
            {
                if(genre.Id==Id )   // kullanıcı tarafından belirlenen Id genreId ile eşitlendiğinde 
                {
                    FakeDate.genre.Remove(genre );  // Listeden bu  Id'yı delete ediyoruz
                }
            }
        }

        public override Genres  GetByName(string name )  // Kullanıcı string bir name girişi yapacak
        {
            Genres findgenre = new Genres();   // instance oluşturduk
            foreach (Genres  genre  in FakeDate.genre) //Fakedata.genre içersinde tek tek satırları dolaşıyoruz 
            {
                if(genre.Name== name ) // Satırlar içerisindeki name ile kullanıcı tarafından  girilen  name eşitlendiğinde 
                {
                    findgenre = genre; // Oluşturduğumuz instance 'e içersindeki genre bilgilerini atıyoruz
                }

            }
            return findgenre; // Bize ulaşmış olduğu genre bilgilerini return olarak veriyor. 
        }

        public override List<Genres> GetGenres() => FakeDate.genre.ToList();  //Fake.Date içeresindeki genre bilgilerini list olarak veriyor
        
        public override void UpdateGenres(Genres genre  )
        {
            foreach (Genres item in FakeDate.genre)
            {
                if(item.Id==genre.Id)  //Data içersindeki Id kullanıcı girdiği Id'ya eşit ise 
                {    //Aşağıdaki bilgileri kulannıcının girdiği değerlere eşitle 
                    item.Id = genre.Id;
                    item.Name = genre.Name;
                    item.Description = genre.Description;
                    break;


                   
                }
            }
        } 
    }
}
