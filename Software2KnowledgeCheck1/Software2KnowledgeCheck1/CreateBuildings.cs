using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    internal class CreateBuildings
    {
       public List<Building> Buildings { get; } = new List<Building>();

       public void CreateStructure(Apartment apartment, HighRise highRise)
       {
           // Get materials
           var materialRepo = new MaterialsRepo();
           var materialsNeeded = materialRepo.GetMaterials();

           var permitRepo = new ZoningAndPermitRepo();

           var apartmentWasMade = ConstructBuilding<Apartment>(materialsNeeded, permitRepo.GetPermit(), permitRepo.ZoningApproves());

           var highRiseWasMade = ConstructBuilding<HighRise>(materialsNeeded, permitRepo.GetPermit(), permitRepo.ZoningApproves());

            if (apartmentWasMade)
            {
                Buildings.Add(apartment);
            }
            else if (highRiseWasMade)
           {
                Buildings.Add(highRise);
           }
       }

       public bool ConstructBuilding<T>(List<string> materials, bool permit, bool zoning) where T : Building
       {
           if (permit && zoning)
           {
               foreach (var material in materials)
               {
                   if (material == "concrete")
                   {
                       // start laying foundation
                   }
                   else if (material == "Steel")
                   {
                       // Start building structure
                   }
                   // etc etc...
               }
               return true;
           }
           else
           {
               return false;
           }
       }
    }
}