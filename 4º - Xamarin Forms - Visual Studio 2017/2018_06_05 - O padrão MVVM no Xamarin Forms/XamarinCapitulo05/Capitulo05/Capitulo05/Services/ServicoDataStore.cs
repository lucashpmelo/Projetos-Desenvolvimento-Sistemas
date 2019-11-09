using Capitulo05.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo05.Services
{
    public class ServicoDataStore : IDataStore<Servico>
    {
        private static List<Servico> servicos = new List<Servico>()
        {
            new Servico() { ServicoID = 1, Nome = "Freios", Valor = 100},
            new Servico() { ServicoID = 2, Nome = "Suspensão", Valor = 200},
            new Servico() { ServicoID = 3, Nome = "Caixa de direção", Valor = 300},
            new Servico() { ServicoID = 4, Nome = "Caixa de câmbio", Valor = 400},
            new Servico() { ServicoID = 5, Nome = "Alinhamento/Balanceamento", Valor = 25}
        };
        public async Task<IEnumerable<Servico>> GetAllAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(servicos);
        }
        /*public Task<bool> AddAsync(Servico item)
        {
            throw new System.NotImplementedException();
        }*/

        public async Task<bool> AddAsync(Servico servico)
        {
            servicos.Add(servico);
            return await Task.FromResult(true);
        }

        /*public Task<bool> DeleteAsync(Servico item)
        {
            throw new System.NotImplementedException();
        }*/

        public async Task<bool> DeleteAsync(Servico servico)
        {
            var _servico = servicos.Where((Servico s) => s.ServicoID == servico.ServicoID).FirstOrDefault();
            servicos.Remove(_servico);
            return await Task.FromResult(true);
        }


        public Task<Servico> GetByIdAsync(long? id)
        {
            throw new System.NotImplementedException();
        }
        /*public Task<bool> UpdateAsync(Servico item)
        {
            throw new System.NotImplementedException();
        }*/

        /*public async Task<bool> UpdateAsync(Servico servico)
        {
            var _servico = servicos.Where((Servico s) => s.ServicoID == servico.ServicoID).FirstOrDefault();
            servicos.Remove(_servico);
            servicos.Add(servico);
            return await Task.FromResult(true);
        }*/

        public async Task<bool> UpdateAsync(Servico servico)
        {
            if (servico.ServicoID != null)
            {
                var _servico = servicos.Where((Servico s) => s.ServicoID == servico.ServicoID).FirstOrDefault();
                servicos.Remove(_servico);
            }
            else
            {
                servico.ServicoID = servicos.Max(s => s.ServicoID) + 1
                ;
            }
            await AddAsync(servico);
            return await Task.FromResult(true);
        }
    }
}

