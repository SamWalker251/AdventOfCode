using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayThree
{
    public class GearTracker
    {
        private List<GearDeatils> _details = new List<GearDeatils>();

        public void GearFound(int y, int x, int PartNum)
        {
            var id = y.ToString() + x.ToString();

            var existing = _details.FirstOrDefault(g => g.GearID.Equals(id) );

            if (existing != null)
            {
                _details.Remove(existing);
                existing.Parts.Add(PartNum);
                _details.Add(existing);
            }
            else
            {

                _details.Add(new GearDeatils()
                {
                    GearID = id,
                    Parts = new List<int>()
                    {
                        PartNum
                    }
                });
            }
        }

        public int GetGearRatioTotal()
        {
            var total = 0;
            foreach (var item in _details)
            {
                if(item.Parts.Count == 2)
                {
                    var ratio = item.Parts.Aggregate((s, a) => s * a);


                    total += ratio;
                }
            }
            return total;
        }
    }

    public class GearDeatils
    {
        public string? GearID { get; set; } //Gears y+x
        public List<int> Parts { get; set; } = new List<int>();

        
    }
}
