using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAL
{
    public class VolunteerDAL
    {
        HospitalVolunteersDBEntities3 DB = new HospitalVolunteersDBEntities3();

        public List<Volunteer> GetVolunteers()
        {
            return DB.Volunteer.ToList();
        }
        public Volunteer GetVolunteerById(int idV)
        {
            return GetVolunteers().Find(x => x.IdVolunteer == idV);
        }
        public int GetRemainingMonthlyHours(int idVolunteer)
        {
            try
            {
                var param = new SqlParameter("@IdVolunteer", idVolunteer);
                var result = DB.Database.SqlQuery<int>(
                    "SELECT dbo.GetRemainingMonthlyHours(@IdVolunteer)", param
                ).FirstOrDefault();
                return result;
            }
            catch (Exception)
            {
                throw;
            }

        }
        public GetTopVolunteersByService_Result GetTopVolunteersByService(int serviceId)
        {
            try
            {
                return DB.GetTopVolunteersByService(serviceId).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }




        public void GetServiceStatistics(int idservice, out int volCnt, out int appRequestCnt)
        {
            try
            {
                var paramServiceId = new SqlParameter
                {
                    ParameterName = "@IdService",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Input,
                    Value = idservice
                };
                var volunteerCnt = new SqlParameter
                {
                    ParameterName = "@VolunteerCount",
                    SqlDbType = System.Data.SqlDbType.Int,
                    Direction = System.Data.ParameterDirection.Output,
                };
                var approved = new SqlParameter
                {
                    ParameterName = "@ApprovedRequestCount",
                    SqlDbType = System.Data.SqlDbType.Int,
                    Direction = System.Data.ParameterDirection.Output,
                };
                DB.Database.SqlQuery<object>("EXEC dbo.GetServiceStatistics @IdService, @VolunteerCount OUTPUT, @ApprovedRequestCount OUTPUT", paramServiceId, volunteerCnt, approved).ToList();
                volCnt = volunteerCnt.Value != null ? Convert.ToInt32(volunteerCnt.Value) : 0;
                appRequestCnt = approved.Value != null ? Convert.ToInt32(approved.Value) : 0;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public bool IsServiceHoursSufficient(int idservice)
        {
            try
            {
                var param = new SqlParameter("@IdService", idservice);
                var result = DB.Database.SqlQuery<bool>(
                    "SELECT dbo.IsServiceHoursSufficient(@IdService)", param
                ).FirstOrDefault();
                return result;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<GetVolunteerAssignmentsDetails_Result> GetVolunteerAssignmentsDetails(int idVolunteer)
        {
            try
            {
                return DB.GetVolunteerAssignmentsDetails(idVolunteer).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void GetVolunteerMonthlyHours(int volunteerId, out int currentMonthHours, out int previousMonthHours)
        {
            try
            {
                var paramVolunteerId = new SqlParameter
                {
                    ParameterName = "@IdVolunteer",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Input,
                    Value = volunteerId
                };
                var paramCurrentMonth = new SqlParameter
                {
                    ParameterName = "@CurrentMonthHours",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };

                var paramPreviousMonth = new SqlParameter
                {
                    ParameterName = "@PreviousMonthHours",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };

                DB.Database.SqlQuery<object>("EXEC dbo.GetVolunteerMonthlyHours @IdVolunteer, @CurrentMonthHours OUTPUT, @PreviousMonthHours OUTPUT",
                    paramVolunteerId, paramCurrentMonth, paramPreviousMonth).ToList();
                currentMonthHours = paramCurrentMonth.Value != null ? Convert.ToInt32(paramCurrentMonth.Value) : 0;
                previousMonthHours = paramPreviousMonth.Value != null ? Convert.ToInt32(paramPreviousMonth.Value) : 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int GetExclusiveServicesCount(int volunteerId)
        {
            try
            {
                var paramVolunteerId = new SqlParameter
                {
                    ParameterName = "@IdVolunteer",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Input,
                    Value = volunteerId
                };
                var result = DB.Database.SqlQuery<int>("SELECT dbo.GetExclusiveServicesCount(@IdVolunteer)", paramVolunteerId).FirstOrDefault();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}