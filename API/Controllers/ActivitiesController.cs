using System;
using Domain;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence;




namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        public readonly DataContext _context;
        public ActivitiesController(DataContext context)
    {
        _context = context;
    }

     [HttpGet]
      public async Task<ActionResult<List<Activity>>> GetActivities()
      {
          return await _context.Activities.ToListAsync();
      }
      
      [HttpGet("{id}")] 
      public async Task<ActionResult<Activity>> GetActivity(Guid id)
      {
          return await _context.Activities.FindAsync(id);
      }
}
}