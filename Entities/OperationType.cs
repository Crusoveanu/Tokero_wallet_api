﻿using System.ComponentModel.DataAnnotations;

namespace Tokero_wallet.Entities
{
    public class OperationType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Operation> Operations { get; set; }
    }
}
