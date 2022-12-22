using Api;
using Domain;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Text;
using System.Reflection.Metadata.Ecma335;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options) { }
    DbSet<User> Users{get;set;}
    DbSet<Club> Clubs{get;set;}
    DbSet<ClubStatistics> ClubStatistics{get;set;}
    DbSet<Match> Matches{get;set;}
    DbSet<Message> Messages{get;set;}
    DbSet<PlayerStatistics> PlayerStatistics{get;set;}
    DbSet<Role> Roles{get;set;}
}