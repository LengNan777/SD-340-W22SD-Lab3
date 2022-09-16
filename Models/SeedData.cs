/*using MyFirstIdentity.Data;
using MyFirstIdentity.Models;
*/
using Microsoft.EntityFrameworkCore;
using SD_340_W22SD_Lab3.Data;

namespace SD_340_W22SD_Lab3.Models
{
    public static class SeedData
    {
        public async static Task Initialize(IServiceProvider serviceProvider)
        {
            var _context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>());

            if (!_context.Routes.Any())
            {
                var routes = new Route[]
                {
                    new Route{Number = 1, Name = "Name1", Direction = Direction.North, RampAccessible = true, BicycleAccessible = true},
                    new Route{Number = 2, Name = "Name2", Direction = Direction.South, RampAccessible = false, BicycleAccessible = false}
                };

                foreach(Route route in routes)
                {
                    _context.Routes.Add(route);
                    _context.SaveChanges();
                }
            }

            if(!_context.Stops.Any())
            {
                var stops = new Stop[]
                {
                    new Stop{Number = 1, Name = "Name1", Direction = Direction.North, Street = "street1"},
                    new Stop{Number = 2, Name = "Name2", Direction = Direction.South, Street = "street2"},
                    new Stop{Number = 3, Name = "Name3", Direction = Direction.East, Street = "street3"},
                    new Stop{Number = 4, Name = "Name4", Direction = Direction.West, Street = "street4"},
                    new Stop{Number = 5, Name = "Name5", Direction = Direction.Northeast, Street = "street5"},
                    new Stop{Number = 6, Name = "Name6", Direction = Direction.Northwest, Street = "street6"},
                    new Stop{Number = 7, Name = "Name7", Direction = Direction.Southeast, Street = "street7"},
                    new Stop{Number = 8, Name = "Name8", Direction = Direction.Southwest, Street = "street8"},
                    new Stop{Number = 9, Name = "Name9", Direction = Direction.North, Street = "street9"},
                    new Stop{Number = 10, Name = "Name10", Direction = Direction.South, Street = "street10"},
                };

                foreach (Stop stop in stops)
                {
                    _context.Stops.Add(stop);
                    _context.SaveChanges();
                }
            }

            if (!_context.ScheduledStops.Any())
            {
                var scheduledStops = new ScheduledStop[]
                {
                    new ScheduledStop{Id = 1, Stop = _context.Stops.First(s=>s.Number==1), Route = _context.Routes.First(r => r.Number == 1), ScheduledArrival = DateTime.Now.AddMinutes(-5)},
                    new ScheduledStop{Id = 2, Stop = _context.Stops.First(s=>s.Number==2), Route = _context.Routes.First(r => r.Number == 1), ScheduledArrival = DateTime.Now.AddMinutes(-10)},
                    new ScheduledStop{Id = 3, Stop = _context.Stops.First(s=>s.Number==3), Route = _context.Routes.First(r => r.Number == 1), ScheduledArrival = DateTime.Now.AddMinutes(-15)},
                    new ScheduledStop{Id = 4, Stop = _context.Stops.First(s=>s.Number==4), Route = _context.Routes.First(r => r.Number == 1), ScheduledArrival = DateTime.Now.AddMinutes(-20)},
                    new ScheduledStop{Id = 5, Stop = _context.Stops.First(s=>s.Number==5), Route = _context.Routes.First(r => r.Number == 1), ScheduledArrival = DateTime.Now.AddMinutes(-25)},
                    new ScheduledStop{Id = 6, Stop = _context.Stops.First(s=>s.Number==6), Route = _context.Routes.First(r => r.Number == 2), ScheduledArrival = DateTime.Now.AddMinutes(-30)},
                    new ScheduledStop{Id = 7, Stop = _context.Stops.First(s=>s.Number==7), Route = _context.Routes.First(r => r.Number == 2), ScheduledArrival = DateTime.Now.AddMinutes(-35)},
                    new ScheduledStop{Id = 8, Stop = _context.Stops.First(s=>s.Number==8), Route = _context.Routes.First(r => r.Number == 2), ScheduledArrival = DateTime.Now.AddMinutes(-40)},
                    new ScheduledStop{Id = 9, Stop = _context.Stops.First(s=>s.Number==9), Route = _context.Routes.First(r => r.Number == 2), ScheduledArrival = DateTime.Now.AddMinutes(-45)},
                    new ScheduledStop{Id = 10, Stop = _context.Stops.First(s=>s.Number==10), Route = _context.Routes.First(r => r.Number == 2), ScheduledArrival = DateTime.Now.AddMinutes(-50)},
                };

                foreach (ScheduledStop scheduledStop in scheduledStops)
                {
                    _context.ScheduledStops.Add(scheduledStop);
                    _context.SaveChanges();
                }
            }

            for(int i = 0; i < 5; i++)
            {
                _context.Routes.First().StopSchedule.Enqueue(_context.ScheduledStops.First(s => s.Id == (i+1)));
                _context.Routes.Last().StopSchedule.Enqueue(_context.ScheduledStops.First(s => s.Id == (10-i)));
            }
            _context.SaveChanges();
        }
    }
}
