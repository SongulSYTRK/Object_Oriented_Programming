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
    public class SamsungRepositoryConrete : SamsungRepository
    {
        public override void CreateSamsung(int Id, string brand, string Model, int unitprice)
        {
            Samsung samsung = new Samsung(Id, brand, Model, unitprice);
        }

        public override void DeleteSamsung(int Id)
        {
            foreach (Samsung samsung in FakePhoneData.samsungs)
            {
                if (samsung.Id == Id)
                {
                    FakePhoneData.samsungs.Remove(samsung);
                }
                else
                {
                    MessageBox.Show("böyle bir ürün yok ");
                }


            }
        }

        public override Samsung GetSamsungIdBy(int Id)
        {
            Samsung findsamsung = new Samsung();
            foreach (Samsung samsung in FakePhoneData.samsungs)
            {
                if (samsung.Id == Id)
                {
                    findsamsung = samsung;
                }

            }
            return findsamsung;
        }

        public override List<Samsung> GetSamsungs()
        {
            return FakePhoneData.samsungs.ToList();

        }

        public override void UpdateSamsung(int Id, string brand, string Model, int unitprice)
        {
            foreach (Samsung samsung in FakePhoneData.samsungs)
            {
                if (samsung.Id == Id)
                {
                    Samsung samsungg = new Samsung(Id, brand, Model, unitprice);

                }

            }
        }
    }
}
