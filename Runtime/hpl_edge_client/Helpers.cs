using HplEdgeClient.Types;
using Solana.Unity.SDK;
using System.Linq;
using System.Threading.Tasks;
using HplEdgeClient.Params;
using HplEdgeClient.Inputs;
using System.Collections.Generic;
using UnityEngine;
using Solana.Unity.Wallet.Utilities;

namespace HplEdgeClient.Helpers
{

    public class TransactionHelper
    {
        public List<Solana.Unity.Rpc.Models.Transaction> Transactions { get; set; } = new();
        public string Blockhash { get; set; }
        public int LastValidBlockHeight { get; set; }

        public TransactionHelper(Transactions transactions)
        {

            foreach (var transaction in transactions.Transactions_)
            {
                Transactions.Add(Solana.Unity.Rpc.Models.VersionedTransaction.Deserialize(Encoders.Base58.DecodeData(transaction)));
            }
            Blockhash = transactions.Blockhash;
            LastValidBlockHeight = transactions.LastValidBlockHeight;
        }

        public TransactionHelper(Transaction transaction)
        {
            var tx_bytes = Encoders.Base58.DecodeData(transaction.Transaction_);
            var tx = Solana.Unity.Rpc.Models.VersionedTransaction.Deserialize(tx_bytes);
            Transactions.Add(tx);
            Blockhash = transaction.Blockhash;
            LastValidBlockHeight = transaction.LastValidBlockHeight;
        }

        public async Task<TransactionHelper> Sign()
        {
            if (Transactions.Count > 0)
            {
                Transactions = (await Web3.Wallet.SignAllTransactions(Transactions.ToArray<Solana.Unity.Rpc.Models.Transaction>())).ToList();
            }
            else
            {
                Debug.LogError("No transaction to sign");
            }
            return this;
        }
        public Transactions Encode()
        {
            return new Transactions
            {
                Transactions_ = Transactions.Select(transaction => Encoders.Base58.EncodeData(transaction.Serialize())).ToList(),
                Blockhash = Blockhash,
                LastValidBlockHeight = LastValidBlockHeight
            };
        }

        public SendBulkTransactionsParams ToSendParams()
        {
            return new SendBulkTransactionsParams
            {
                Txs = Transactions.Select(transaction => Encoders.Base58.EncodeData(transaction.Serialize())).ToList(),
                Blockhash = Blockhash,
                LastValidBlockHeight = LastValidBlockHeight

            };
        }
        public SendBulkTransactionsParams ToSendParams(SendTransactionBundlesOptions options)
        {
            return new SendBulkTransactionsParams
            {
                Txs = Transactions.Select(transaction => Encoders.Base58.EncodeData(transaction.Serialize())).ToList(),
                Blockhash = Blockhash,
                LastValidBlockHeight = LastValidBlockHeight,
                Options = options
            };
        }

    }

}