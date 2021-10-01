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
        public override void CreateIphone(Guid Id, string brand, string Model, int unitprice)
        {
            Iphone iphone = new Iphone(Id, brand, Model, unitprice);
        }

        public override void DeleteIphone(Guid id)
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

        public override void Find(Guid Id, string brand, string Model, int unitprice)
        {
            throw new NotImplementedException();
        }

        public override List<Iphone> GetIphone()
        {
            return FakePhoneData.iphones.ToList();
        }

        public override Iphone GetIphoneById(Guid id)
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

        public override void UpdateIphone(Guid Id, string brand, string Model, int unitprice)
        {
            foreach (Iphone iphone in FakePhoneData.iphones)
            {
                if (iphone.Id == Id)
                {
                    iphone.Brand = brand;
                    iphone.Model = Model;
                    iphone.Unitprice = unitprice;



                }
            }
        }
    }
}




