using PM3.Data.Infrastructure;
using PM3.Data.Repositories;
using PM3.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Service
{
    // operations we'll expose
    public interface IAccidentCodeService
    {
        IEnumerable<AccidentCode> GetAccidentCodes();
        AccidentCode GetAccidentCode(string id);
        void CreateAccidentCode(AccidentCode accidentcode);
        void SaveAccidentCode();
    }

    // implementation of those operations
    public class AccidentCodeService : IAccidentCodeService
    {
        private readonly IAccidentCodeRepository accidentCodeRepository;
        private readonly IUnitOfWork unitOfWork;

        //         public GadgetService(IGadgetRepository gadgetsRepository, ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)

        public AccidentCodeService(IAccidentCodeRepository accidentCodeRepository, IUnitOfWork unitOfWork)
        {
            this.accidentCodeRepository = accidentCodeRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<AccidentCode> GetAccidentCodes()
        {
            var accidentCodes = accidentCodeRepository.GetAll();
            return accidentCodes;
        }
        public AccidentCode GetAccidentCode(string id)
        {
            var accidentcode = accidentCodeRepository.GetById(id);
            return accidentcode;
        }
        public void CreateAccidentCode(AccidentCode accidentCode)
        {
            accidentCodeRepository.Add(accidentCode);
        }
        public void SaveAccidentCode()
        {
            unitOfWork.Commit();
        }
    }
}
