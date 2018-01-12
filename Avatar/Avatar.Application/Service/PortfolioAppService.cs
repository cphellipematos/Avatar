using Avatar.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using DomainNotificationHelperCore.Commands;
using Avatar.Domain.Interfaces.Repository;
using Avatar.Domain.Commands.PortfolioCommands;

namespace Avatar.Application.Service
{
    public class PortfolioAppService : IPortfolioAppService
    {
        private IPortfolioRepository _portfolioRepository;


        public PortfolioAppService(IPortfolioRepository portfolioRepository)
        {
            _portfolioRepository = portfolioRepository;
        }
        public IEnumerable<GetPortfoliosCommand> GetPortfolios()
        {
            return new GetPortfoliosCommand().ToCommandList(_portfolioRepository.GetAll());
        }
    }
}
