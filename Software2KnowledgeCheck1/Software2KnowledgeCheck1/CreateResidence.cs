using System;
namespace Software2KnowledgeCheck1
{
    internal class CreateResidence
    {
        public CreateResidence()
        {
            void CreateApartment(Apartment apartment)
            {
                // Get materials
                CreateBuilding;
                var materialRepo = new MaterialsRepo();
                var materialsNeeded = materialRepo.GetMaterials();

                var permitRepo = new ZoningAndPermitRepo();

                var buildingWasMade = CreateBuilding<Apartment>(materialsNeeded, permitRepo.GetPermit(), permitRepo.ZoningApproves());

                if (buildingWasMade)
                {
                    Buildings.Add(apartment);
                }
            }
        }
    }
}

