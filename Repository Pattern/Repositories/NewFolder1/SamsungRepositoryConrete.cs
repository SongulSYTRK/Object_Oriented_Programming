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
        public override void CreateSamsung(Guid  id , string brand, string Model, int unitprice)
        {
            Samsung samsung = new Samsung(id,  brand, Model, unitprice );
        }

        public override void DeleteSamsung(Guid id)
        {
            foreach(Samsung samsung in FakePhoneData.samsungs)
            {
                if (samsung.Id== id )
                {
                    FakePhoneData.samsungs.Remove(samsung);
                }
                else
                {
                    MessageBox.Show( "böyle bir ürün yok ");
                }
                

            }
        }

        public override List<Samsung> GetSamsungs( )
        {
            return FakePhoneData.samsungs.ToList();

        }

        public override void UpdateSamsung(Guid Id, string brand, string Model, int unitprice)
        {
            foreach(Samsung samsung in FakePhoneData.samsungs)
            {
                if (samsung.Id== Id)
                {
                    Samsung samsungg = new Samsung(Id, brand, Model,unitprice);

                }

            }
        }
    }
}
