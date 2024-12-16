using AnniesCatSanctuary.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace AnniesCatSanctuary.Services
{
    public class PetManagementService
    {
        private readonly AppDbContext _context;

        public PetManagementService(AppDbContext context)
        {
            _context = context;
        }

        public List<Pet> GetPets()
        {
            return _context.Pets.ToList();
        }

        public void AddPet(Pet newPet)
        {
            _context.Pets.Add(newPet);
            _context.SaveChanges();
        }

        public void RemovePet(Pet petToRemove)
        {
            var pet = _context.Pets.Find(petToRemove.Id);
            if (pet != null)
            {
                _context.Pets.Remove(pet);
                _context.SaveChanges();
            }
        }

        public void HidePet(Pet petToHide)
        {
            var pet = _context.Pets.Find(petToHide.Id);
            if (pet != null)
            {
                pet.IsHidden = true;
                _context.SaveChanges();
            }
        }

        public void UnhidePet(Pet petToUnhide)
        {
            var pet = _context.Pets.Find(petToUnhide.Id);
            if (pet != null)
            {
                pet.IsHidden = false;
                _context.SaveChanges();
            }
        }
    }
}
