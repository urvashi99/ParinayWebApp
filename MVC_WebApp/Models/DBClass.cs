using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_WebApp.Models
{
    public class DBClass
    {
        public readonly string constr = System.Configuration.ConfigurationManager.
    ConnectionStrings["dbconnection"].ConnectionString;

        public List<ProfileDto> getAllProfiles()
        {
            string procname = "SP_GETPROFILE";
            List<ProfileDto> empList = new List<ProfileDto>();
            ProfileDto profile;
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand objSqlCommand = new SqlCommand(procname, con);
                objSqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter(objSqlCommand);
                try
                {
                    objSqlDataAdapter.Fill(ds);
                    for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        profile = new ProfileDto();
                        profile.PID = Convert.ToInt32(ds.Tables[0].Rows[i]["PID"].ToString());
                        profile.FirstName = ds.Tables[0].Rows[i]["FirstName"].ToString();
                        profile.MiddleName = ds.Tables[0].Rows[i]["MiddleName"].ToString();
                        profile.LastName = ds.Tables[0].Rows[i]["LastName"].ToString();
                        profile.DOB = Convert.ToDateTime(ds.Tables[0].Rows[i]["DOB"].ToString());
                        profile.Age = Convert.ToInt32(ds.Tables[0].Rows[i]["Age"].ToString());
                        profile.GenderText = ds.Tables[0].Rows[i]["Gender"].ToString();
                        profile.ReligionText = ds.Tables[0].Rows[i]["Religion"].ToString();
                        profile.CommunityID = Convert.ToInt32(ds.Tables[0].Rows[i]["CommunityID"].ToString());
                        profile.PrimaryMobileNo = ds.Tables[0].Rows[i]["PrimaryMobileNo"].ToString();
                        profile.EmailID = ds.Tables[0].Rows[i]["EmailID"].ToString();
                        empList.Add(profile);
                        profile = null;
                    }
                }
                catch (Exception ex)
                {
                }
            }
            return empList;
        }

        public DropdownDto GetDropdownList()
        {
            DropdownDto obj = new DropdownDto();
            List<SelectListItem> genderlst = new List<SelectListItem>();
            List<SelectListItem> heightlst = new List<SelectListItem>();
            List<SelectListItem> religionlst = new List<SelectListItem>();
            List<SelectListItem> communitylst = new List<SelectListItem>();
            List<SelectListItem> mother_toungelst = new List<SelectListItem>();
            List<SelectListItem> qualificationlst = new List<SelectListItem>();
            List<SelectListItem> workinglst = new List<SelectListItem>();
            List<SelectListItem> work_typelst = new List<SelectListItem>();
            List<SelectListItem> professionlst = new List<SelectListItem>();
            List<SelectListItem> incomelst = new List<SelectListItem>();
            List<SelectListItem> eatinglst = new List<SelectListItem>();
            try
            {
                SqlConnection con = new SqlConnection(constr);
                string com = "select Id, Type, OtherDetails, Parameter from tblParameter ";
                SqlDataAdapter adpt = new SqlDataAdapter(com, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["Parameter"].ToString() == "Gender")
                    {
                        genderlst.Add(new SelectListItem
                        {
                            Value = dt.Rows[i]["Id"].ToString(),
                            Text = dt.Rows[i]["Type"].ToString()

                        });

                    }
                    if (dt.Rows[i]["Parameter"].ToString() == "Height")
                    {
                        heightlst.Add(new SelectListItem
                        {
                            Value = dt.Rows[i]["Id"].ToString(),
                            Text = dt.Rows[i]["Type"].ToString()

                        });

                    }
                    if (dt.Rows[i]["Parameter"].ToString() == "Religion")
                    {
                        religionlst.Add(new SelectListItem
                        {
                            Value = dt.Rows[i]["Id"].ToString(),
                            Text = dt.Rows[i]["Type"].ToString()

                        });

                    }
                    if (dt.Rows[i]["Parameter"].ToString() == "Community")
                    {
                        communitylst.Add(new SelectListItem
                        {
                            Value = dt.Rows[i]["Id"].ToString(),
                            Text = dt.Rows[i]["Type"].ToString()

                        });

                    }

                    if (dt.Rows[i]["Parameter"].ToString() == "MotherTounge")
                    {
                        mother_toungelst.Add(new SelectListItem
                        {
                            Value = dt.Rows[i]["Id"].ToString(),
                            Text = dt.Rows[i]["Type"].ToString()

                        });

                    }
                    if (dt.Rows[i]["Parameter"].ToString() == "Qualification")
                    {
                        qualificationlst.Add(new SelectListItem
                        {
                            Value = dt.Rows[i]["Id"].ToString(),
                            Text = dt.Rows[i]["Type"].ToString()

                        });

                    }
                    if (dt.Rows[i]["Parameter"].ToString() == "Working")
                    {
                        workinglst.Add(new SelectListItem
                        {
                            Value = dt.Rows[i]["Id"].ToString(),
                            Text = dt.Rows[i]["Type"].ToString()

                        });

                    }
                    if (dt.Rows[i]["Parameter"].ToString() == "Work")
                    {
                        work_typelst.Add(new SelectListItem
                        {
                            Value = dt.Rows[i]["Id"].ToString(),
                            Text = dt.Rows[i]["Type"].ToString()

                        });

                    }
                    if (dt.Rows[i]["Parameter"].ToString() == "Profession")
                    {
                        professionlst.Add(new SelectListItem
                        {
                            Value = dt.Rows[i]["Id"].ToString(),
                            Text = dt.Rows[i]["Type"].ToString()

                        });

                    }
                    if (dt.Rows[i]["Parameter"].ToString() == "Income")
                    {
                        incomelst.Add(new SelectListItem
                        {
                            Value = dt.Rows[i]["Id"].ToString(),
                            Text = dt.Rows[i]["Type"].ToString()

                        });

                    }
                    if (dt.Rows[i]["Parameter"].ToString() == "Eating")
                    {
                        eatinglst.Add(new SelectListItem
                        {
                            Value = dt.Rows[i]["Id"].ToString(),
                            Text = dt.Rows[i]["Type"].ToString()

                        });

                    }

                }
                obj.gender = genderlst;
                obj.height = heightlst;
                obj.religion = religionlst;
                obj.community = communitylst;
                obj.mother_tounge = mother_toungelst;
                obj.qualification = qualificationlst;
                obj.working = workinglst;
                obj.work_type = work_typelst;
                obj.profession = professionlst;
                obj.income = incomelst;
                obj.eating = eatinglst;
            }
            catch (Exception ex)
            {

            }
            return obj;
        }

        public int SaveProfile(ProfileDto emp)
        {
            string saveproc = "SP_SAVE_PROFILE";
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand objSqlCommand = new SqlCommand(saveproc, con);
                objSqlCommand.CommandType = CommandType.StoredProcedure;
                objSqlCommand.Parameters.AddWithValue("@DOB", emp.DOB);
                objSqlCommand.Parameters.AddWithValue("@FirstName", emp.FirstName);
                objSqlCommand.Parameters.AddWithValue("@MiddleName", emp.MiddleName);
                objSqlCommand.Parameters.AddWithValue("@LastName", emp.LastName);
                objSqlCommand.Parameters.AddWithValue("@GenderID", emp.GenderID);
                objSqlCommand.Parameters.AddWithValue("@HeightID", emp.HeightID);
                objSqlCommand.Parameters.AddWithValue("@Weight", emp.Weight);
                objSqlCommand.Parameters.AddWithValue("@ReligionID", emp.ReligionID);
                objSqlCommand.Parameters.AddWithValue("@CommunityID", emp.CommunityID);
                objSqlCommand.Parameters.AddWithValue("@MotherToungueID", emp.MotherToungeID);
                objSqlCommand.Parameters.AddWithValue("@QualificationID", emp.QualificationID);
                objSqlCommand.Parameters.AddWithValue("@IsWorkingID", emp.IsWorkingID);
                objSqlCommand.Parameters.AddWithValue("@WorkingWithID", emp.WorkingWithID);
                objSqlCommand.Parameters.AddWithValue("@ProfessionalID", emp.ProfessionID);
                objSqlCommand.Parameters.AddWithValue("@Company", emp.Company);
                objSqlCommand.Parameters.AddWithValue("@IncomeID", emp.IncomeID);
                objSqlCommand.Parameters.AddWithValue("@CreatingFor", emp.CreatingFor);
                objSqlCommand.Parameters.AddWithValue("@MoreDetails", emp.MoreDetails);
                objSqlCommand.Parameters.AddWithValue("@PrimaryMobileNo", emp.PrimaryMobileNo);
                objSqlCommand.Parameters.AddWithValue("@AlternateMobileNo", emp.AlternateMobileNo);
                objSqlCommand.Parameters.AddWithValue("@EmailID", emp.EmailID);
                objSqlCommand.Parameters.AddWithValue("@ProfileImageURL1", emp.ProfileImageURL1 == null ? "Test" : emp.ProfileImageURL1);
                objSqlCommand.Parameters.AddWithValue("@ProfileImageURL2", emp.ProfileImageURL2 == null ? "Test" : emp.ProfileImageURL2);
                objSqlCommand.Parameters.AddWithValue("@ProfileImageURL3", emp.ProfileImageURL3 == null ? "Test" : emp.ProfileImageURL3);
                objSqlCommand.Parameters.AddWithValue("@ProfileImageURL4", emp.ProfileImageURL4 == null ? "Test" : emp.ProfileImageURL4);
                objSqlCommand.Parameters.AddWithValue("@EatingID", emp.EatingID);
                objSqlCommand.Parameters.AddWithValue("@EmpId", emp.EmpId);
                try
                {
                    con.Open();
                    int i = objSqlCommand.ExecuteNonQuery();
                    con.Close();
                    return i;
                }
                catch (Exception ex)
                {
                }
            }
            return 0;
        }


        public int ValidateUserLoginInfo(string empid, string pass)
        {
            string procname = "SP_VERIFY_LOGIN_INFO";
            DataSet ds = new DataSet();
            int empId = 0;
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand(procname, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpId", empid);
                cmd.Parameters.AddWithValue("@Pwd", pass);
                SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter(cmd);
                try
                {
                    objSqlDataAdapter.Fill(ds);
                    if(ds.Tables[0].Rows.Count > 0)
                    {
                        empId = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                    }
                }
                catch (Exception ex)
                {
                }
            }
            return empId;
        }
    }
}