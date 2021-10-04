using Abstraction.Entities.Concrete;
using Repository_Pattern.Repositories.Abstract_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repository_Pattern.Repositories.NewFolder1
{
    public class NokiaRepositoryConcrete : NokiaRepository
    {
        public override void CreateNokia(int Id, string brand, string Model, int unitprice)
        {
            Nokia nokia = new Nokia(Id, brand, Model, unitprice);
        }

        public override void DeleteNokia(int Id)
        {
            foreach (Nokia nokia in FakePhoneData.nokias)
            {
                if (nokia.Id == Id)
                {
                    FakePhoneData.nokias.Remove(nokia);
                }
                else
                {
                    MessageBox.Show("Böyle bir ürün yok ");
                }
            }
        }


        public override List<Nokia> GetNokia()
        {
            return FakePhoneData.nokias.ToList();

        }

        public override Nokia GetNokiaById(int Id)
        {
            Nokia findnokia = new Nokia();
            foreach (Nokia nokia in FakePhoneData.nokias)
            {
                if (nokia.Id == Id)
                {
                    findnokia = nokia;
                }

            }
            return findnokia;
        }

        public override void UpdateNokia(int Id, string brand, string Model, int unitprice)
        {
            foreach (Nokia nokia in FakePhoneData.nokias)
            {
                if (nokia.Id == Id)
                {
                    Nokia nokiaa = new Nokia(Id, brand, Model, unitprice);
                }
            }
        }
    }
}
