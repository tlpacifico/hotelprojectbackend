using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.UnitofWork;
using Domain.UnitOfWork;
using Domain.Entity;

namespace IlhaBela.Tests.Crud
{
    [TestClass]
    public class CamaTest
    {
        public IUnitOfWork _unitOfWork;

        [TestInitialize]
        public void Initialize()
        {
            _unitOfWork =  new UnitOfWork();
        }

        [TestMethod]
        public void InserirCama()
        {
            Cama obj = new Cama();
            obj.DsCama = "unit inser";
            obj.IdHotel = 4;
            obj.NumCapacidade = 3;
            bool chdmo = _unitOfWork.CamaRepository.Insert(obj);
            Assert.IsTrue(chdmo);
        }
    }
}
