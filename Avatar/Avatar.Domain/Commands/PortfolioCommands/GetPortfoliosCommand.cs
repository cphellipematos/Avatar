using Avatar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Commands.PortfolioCommands
{
    public class GetPortfoliosCommand
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string url { get; set; }
        public string github { get; set; }        

        public GetPortfoliosCommand ToCommand(Portfolio portfolio)
        {
            return new GetPortfoliosCommand()
            {
                id = portfolio.Id,
                name = portfolio.Name,
                image = portfolio.Image,
                url = portfolio.Url,                
                github = portfolio.Github
            };
        }

        public IEnumerable<GetPortfoliosCommand> ToCommandList(IEnumerable<Portfolio> portfolios)
        {
            if (portfolios == null)
                return new List<GetPortfoliosCommand>();

            var portfoliosCommand = new List<GetPortfoliosCommand>();

            foreach (var company in portfolios)
            {
                portfoliosCommand.Add(ToCommand(company));
            }
            return portfoliosCommand;
        }
    }
}
