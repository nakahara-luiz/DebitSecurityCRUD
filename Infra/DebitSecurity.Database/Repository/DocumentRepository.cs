using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DebitSecurity.Database.Context;
using DebitSecurity.Domain.Entities;
using DebitSecurity.Interface.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace DebitSecurity.Database.Repository
{
    public class DocumentRepository : BaseRepository<Document>, IDocumentRepository
    {
        public DocumentRepository(DebitSecurityDbContext sqlContext) :base(sqlContext)
        {
        }

        public IList<Document> GetMock() {
            return new List<Document> {
                new Document {
                    Customer = new Person {
                        CPF = "07848526911",
                        Name = "Luiz Teste",
                        Id = 1
                    },
                    Debit = new Debit {
                        DocumentId = 1,
                        Installments = new List<Installment> {
                            new Installment {
                                DebitID = 1,
                                DueDate = DateTime.Now,
                                InstallmentNumber = 1,
                                Value = 12500,
                                Id = 1
                            },
                            new Installment {
                                DebitID = 1,
                                DueDate = DateTime.Now.AddDays(30),
                                InstallmentNumber = 2,
                                Value = 12500,
                                Id = 2
                            },
                            new Installment {
                                DebitID = 1,
                                DueDate = DateTime.Now.AddDays(60),
                                InstallmentNumber = 3,
                                Value = 12500,
                                Id = 3
                            }
                        },
                        Interest = 5,
                        Penalty = 2,
                        Id = 1
                    },
                    DocumentNumber = "0123456",
                    Id = 1
                }
            };
        }

        public async Task<IList<Document>> GetComplete() {
            IQueryable<Document> query = _sqlContext.DebitSecurities
                .Include(ds => ds.Customer)
                .Include(ds => ds.Debit)
                .ThenInclude(d => d.Installments);

            query = query.OrderByDescending(d => d.DocumentNumber);

            return await query.ToArrayAsync();
        }

        public async Task<Document> GetComplete(int idDoc = 0){
            IQueryable<Document> query = _sqlContext.DebitSecurities
                .Include(ds => ds.Customer)
                .Include(ds => ds.Debit)
                .ThenInclude(d => d.Installments);

            query = query.OrderByDescending(d => d.DocumentNumber)
                .Where(d => idDoc > 0 && d.Id == idDoc);

            return await query.FirstOrDefaultAsync();
        }
    }
}