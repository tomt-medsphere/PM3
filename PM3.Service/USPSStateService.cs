using PM3.Data.Infrastructure;
using PM3.Data.Repositories;
using PM3.Model.Models;
using System.Collections.Generic;

namespace PM3.Service
{
    // operations we'll expose
    public interface IUSPSStateService
    {
        IEnumerable<USPSState> GetUSPSStates();
        USPSState GetUSPSState(string id);
        void CreateUSPSState(USPSState uspsState);
        void Update(USPSState uspsState);
        void Delete(USPSState uspsState);
        void SaveUSPSState();
    }

    // implementation of those operations
    public class USPSStateService : IUSPSStateService
    {
        private readonly IUSPSStateRepository _uspsStateRepository;
        private readonly IUnitOfWork _unitOfWork;

        public USPSStateService(IUSPSStateRepository uspsStateRepository, IUnitOfWork unitOfWork)
        {
            this._uspsStateRepository = uspsStateRepository;
            this._unitOfWork = unitOfWork;
        }

        public IEnumerable<USPSState> GetUSPSStates()
        {
            var uspsStates = _uspsStateRepository.GetAll();
            return uspsStates;
        }
        public USPSState GetUSPSState(string id)
        {
            var uspsState = _uspsStateRepository.GetById(id);
            return uspsState;
        }
        public void CreateUSPSState(USPSState uspsState)
        {
            _uspsStateRepository.Add(uspsState);
        }

        public void Update(USPSState uspsState)
        {
            _uspsStateRepository.Update(uspsState);
        }

        public void Delete(USPSState uspsState)
        {
            _uspsStateRepository.Delete(uspsState);
        }

        public void SaveUSPSState()
        {
            _unitOfWork.Commit();
        }
    }
}
