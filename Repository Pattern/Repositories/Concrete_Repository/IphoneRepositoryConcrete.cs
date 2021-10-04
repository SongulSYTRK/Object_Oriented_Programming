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
    class IphoneRepositoryConcrete : IphoneRepository
    {
        public override void CreateIphone(int id, string brand, string Model, int unitprice)
        {
            Iphone iphone = new Iphone(id, brand, Model, unitprice);
            FakePhoneData.iphones.Add(iphone);
        }

        public override void DeleteIphone(int id)
        {
            foreach (Iphone iphone in FakePhoneData.iphones)
            {
                if (iphone.Id == id)
                {
                    FakePhoneData.iphones.Remove(iphone);
                }
                else
                {
                    MessageBox.Show("böyle bir ürün yok ");
                }
            }
        }

        
        public override List<Iphone> GetIphone()
        {
            return FakePhoneData.iphones.ToList();
        }

        public override Iphone GetIphoneById(int id)
        {
            Iphone findiphone = new Iphone();
            foreach (Iphone iphone in FakePhoneData.iphones)
            {
                if (iphone.Id == id)
                {
                    findiphone = iphone;
                }

            }
            return findiphone;
        }

        public override void UpdateIphone(int id, string brand, string Model, int unitprice)
        {
            foreach (Iphone iphone in FakePhoneData.iphones)
            {
                if (iphone.Id == id)
                {
                    iphone.Brand = brand;
                    iphone.Model = Model;
                    iphone.Unitprice = unitprice;

                    FakePhoneData.iphones.Add(iphone);

                }
            }
        }
    }
}




