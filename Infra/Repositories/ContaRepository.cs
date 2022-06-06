using Core.Interface;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class ContaRepository : IConta
    {
        private readonly StoreContext _store;
        public ContaRepository(StoreContext store)
        {
            _store = store;
        }

        public async Task<Conta> CreateContas(Conta conta)
        {
            await _store.Set<Conta>().AddAsync(conta);
            _store.SaveChanges();
            return conta;
        }

        public async Task<Conta> DeleteContas(int id)
        {
            var conta = await _store.Set<Conta>().FindAsync(id);
            if (conta == null)
            {
                return conta;
            }
            _store.Set<Conta>().Remove(conta);
            await _store.SaveChangesAsync();
            return conta;
        }

        public async Task<IReadOnlyList<Conta>> GetContas()
        {
            return await _store.Set<Conta>().ToListAsync();
        }

        public async Task<Conta> GetContasByCc(ContaBancaria cc)
        {
            return await _store.Set<Conta>().FindAsync(cc);
        }

        public async Task<Conta> GetContasByDescricao(string descricao)
        {
            return await _store.Set<Conta>().FindAsync(descricao);
        }

        public async Task<Conta> GetContasByEmissao(DateTime emissao)
        {
            return await _store.Set<Conta>().FindAsync(emissao);
        }

        public async Task<Conta> GetContasByFornecedor(Fornecedor fornecedor)
        {
            return await _store.Set<Conta>().FindAsync(fornecedor);
        }

        public async Task<Conta> GetContasById(int id)
        {
            return await _store.Set<Conta>().FindAsync(id);
        }

        public async Task<Conta> GetContasByNome(string nome)
        {
            return await _store.Set<Conta>().FindAsync(nome);
        }

        public async Task<Conta> GetContasByPago(bool pago)
        {
            return await _store.Set<Conta>().FindAsync(pago);
        }

        public async Task<Conta> GetContasByValor(double valor)
        {
            return await _store.Set<Conta>().FindAsync(valor);
        }

        public async Task<Conta> GetContasByVencimento(DateTime vencimento)
        {
            return await _store.Set<Conta>().FindAsync(vencimento);
        }

        public async Task<Conta> UpdateContas(Conta conta)
        {
            _store.Entry(conta).State = EntityState.Modified;
            await _store.SaveChangesAsync();
            return conta;
        }
    }
}
