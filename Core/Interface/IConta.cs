using Core.Entities;

namespace Core.Interface
{
    public interface IConta
    {
        Task<IReadOnlyList<Conta>> GetContas();
        Task<Conta> GetContasById(int id);
        Task<Conta> GetContasByNome(string nome);
        Task<Conta> GetContasByDescricao(string descricao);
        Task<Conta> GetContasByCc(ContaBancaria cc);
        Task<Conta> GetContasByValor(double valor);
        Task<Conta> GetContasByVencimento(DateTime vencimento);
        Task<Conta> GetContasByEmissao(DateTime emissao);
        Task<Conta> GetContasByFornecedor(Fornecedor fornecedor);
        Task<Conta> GetContasByPago(bool pago);
        Task<Conta> CreateContas(Conta conta);
        Task<Conta> UpdateContas(Conta conta);
        Task<Conta> DeleteContas(int id);


    }
}
