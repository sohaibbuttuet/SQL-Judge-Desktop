using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal abstract class AuditableEntity
    {
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public int CreatedBy { get; private set; }
        public int UpdatedBy { get; private set; }
  
        public void MarkCreated(int userId)
        {
            if (userId <= 0)
                throw new ArgumentException("Invalid user id.");

            CreatedBy = userId;
            CreatedAt = DateTime.Now;
        }
        public void MarkUpdated(int userId)
        {
            if (userId <= 0)
                throw new ArgumentException("Invalid user id.");

            UpdatedBy = userId;
            UpdatedAt = DateTime.Now;
        }

        protected void LoadAuditData(int createdBy, DateTime createdAt, int updatedBy, DateTime updatedAt)
        {
            CreatedBy = createdBy;
            CreatedAt = createdAt;

            UpdatedBy = updatedBy;
            UpdatedAt = updatedAt;
        }
    }
}
