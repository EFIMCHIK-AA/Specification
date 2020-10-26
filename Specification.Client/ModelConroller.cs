using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Specification.Client.Data;
using Specification.Client.Models;

namespace Specification.Client
{
    public class ModelConroller 
    {
        private ApplicationContext _context;

        public ModelConroller()
        {
            _context = new ApplicationContext();
        }

        public List<Model> GetModels()
        {
            using (ApplicationContext _context = new ApplicationContext())
            {
                return _context.Models.ToList();
            }
        }

        public (Model, bool) Add(Model model)
        {
            try
            {
                _context.Models.Add(model);
                _context.SaveChanges();
                return (model, true);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public (Model, bool) Update(Model model)
        {
            try
            {
                Model modelContext = _context.Models.FirstOrDefault(m => m.Id == model.Id);

                _context.Models.Remove(modelContext);
                _context.SaveChanges();
                return (model, true);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }     
        }

        public (int, bool) Delete(int Id)
        {
            try
            {
                Model modelContext = _context.Models.FirstOrDefault(m => m.Id == Id);

                _context.Models.Remove(modelContext);
                _context.SaveChanges();
                return (Id, true);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
