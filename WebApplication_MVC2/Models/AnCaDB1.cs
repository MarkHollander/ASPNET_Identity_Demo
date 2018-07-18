using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace WebApplication_MVC.Models
{
    public partial class MealOfUser
    {
        [Key]
        public virtual int Meal_Id { get; set; }

        public virtual int User_Id { get; set; }

        [Range(typeof(int), "0", "2147483647")]
        public virtual int Ca1 { get; set; }

        [Range(typeof(int), "0", "2147483647")]
        public virtual int Ca2 { get; set; }

        [Range(typeof(int), "0", "2147483647")]
        public virtual int Ca3 { get; set; }

        public virtual DateTime CreateDate { get; set; }
    }

    public partial class Unit
    {
        [Key]
        public virtual int Unit_Id { get; set; }
        public virtual string Unit_Name { get; set; }
        public virtual string Unit_Description { get; set; }
        public ICollection<User> Users { get; set; }
    }

    public partial class User
    {
        [Key]
        public virtual int User_Id { get; set; }
        [Required]
        public virtual string User_Name { get; set; }
        public virtual string Password { get; set; }         
        public virtual int Unit_Id { get; set; }
        public virtual int Role_Id { get; set; }
    }

    public partial class Role
    {
        [Key]
        public virtual int Role_Id { get; set; }
        public virtual string Role_Name { get; set; }                
    }

    public class AnCaDContext: DbContext
    {
        public AnCaDContext(): base("AnCaDB1") { }
        public DbSet<MealOfUser> MealsOfUser { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}