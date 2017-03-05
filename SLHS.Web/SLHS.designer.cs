﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SLHS.Web
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SLHS_DB")]
	public partial class SLHSDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertRole(Role instance);
    partial void UpdateRole(Role instance);
    partial void DeleteRole(Role instance);
    partial void InsertMember(Member instance);
    partial void UpdateMember(Member instance);
    partial void DeleteMember(Member instance);
    partial void InsertChoiceSet(ChoiceSet instance);
    partial void UpdateChoiceSet(ChoiceSet instance);
    partial void DeleteChoiceSet(ChoiceSet instance);
    partial void InsertChoice(Choice instance);
    partial void UpdateChoice(Choice instance);
    partial void DeleteChoice(Choice instance);
    partial void InsertQuestion(Question instance);
    partial void UpdateQuestion(Question instance);
    partial void DeleteQuestion(Question instance);
    #endregion
		
		public SLHSDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SLHS_DBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SLHSDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SLHSDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SLHSDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SLHSDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Role> Roles
		{
			get
			{
				return this.GetTable<Role>();
			}
		}
		
		public System.Data.Linq.Table<Member> Members
		{
			get
			{
				return this.GetTable<Member>();
			}
		}
		
		public System.Data.Linq.Table<ChoiceSet> ChoiceSets
		{
			get
			{
				return this.GetTable<ChoiceSet>();
			}
		}
		
		public System.Data.Linq.Table<Choice> Choices
		{
			get
			{
				return this.GetTable<Choice>();
			}
		}
		
		public System.Data.Linq.Table<Question> Questions
		{
			get
			{
				return this.GetTable<Question>();
			}
		}
		
		public System.Data.Linq.Table<QuestionResult> QuestionResults
		{
			get
			{
				return this.GetTable<QuestionResult>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Roles")]
	public partial class Role : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Content;
		
		private EntitySet<Member> _Members;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnContentChanging(string value);
    partial void OnContentChanged();
    #endregion
		
		public Role()
		{
			this._Members = new EntitySet<Member>(new Action<Member>(this.attach_Members), new Action<Member>(this.detach_Members));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Content", DbType="NVarChar(50)")]
		public string Content
		{
			get
			{
				return this._Content;
			}
			set
			{
				if ((this._Content != value))
				{
					this.OnContentChanging(value);
					this.SendPropertyChanging();
					this._Content = value;
					this.SendPropertyChanged("Content");
					this.OnContentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Role_Member", Storage="_Members", ThisKey="Id", OtherKey="RoleId")]
		public EntitySet<Member> Members
		{
			get
			{
				return this._Members;
			}
			set
			{
				this._Members.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Members(Member entity)
		{
			this.SendPropertyChanging();
			entity.Role = this;
		}
		
		private void detach_Members(Member entity)
		{
			this.SendPropertyChanging();
			entity.Role = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Members")]
	public partial class Member : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _RoleId;
		
		private string _Username;
		
		private string _Password;
		
		private string _Email;
		
		private System.DateTime _CreatedDate;
		
		private System.Nullable<System.DateTime> _LastLoginDate;
		
		private EntityRef<Role> _Role;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnRoleIdChanging(int value);
    partial void OnRoleIdChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnCreatedDateChanging(System.DateTime value);
    partial void OnCreatedDateChanged();
    partial void OnLastLoginDateChanging(System.Nullable<System.DateTime> value);
    partial void OnLastLoginDateChanged();
    #endregion
		
		public Member()
		{
			this._Role = default(EntityRef<Role>);
			OnCreated();
		}

        public Role getRole()
        {
            SLHSDataContext SLHS_DB = new SLHSDataContext();
            IQueryable<Role> roleQuery = from r in SLHS_DB.Roles
                                    where this.RoleId == r.Id
                                    select r;

            Role role = roleQuery.First<Role>();
            return role;
        }
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleId", DbType="Int NOT NULL")]
		public int RoleId
		{
			get
			{
				return this._RoleId;
			}
			set
			{
				if ((this._RoleId != value))
				{
					if (this._Role.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRoleIdChanging(value);
					this.SendPropertyChanging();
					this._RoleId = value;
					this.SendPropertyChanged("RoleId");
					this.OnRoleIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedDate", DbType="DateTime NOT NULL")]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._CreatedDate;
			}
			set
			{
				if ((this._CreatedDate != value))
				{
					this.OnCreatedDateChanging(value);
					this.SendPropertyChanging();
					this._CreatedDate = value;
					this.SendPropertyChanged("CreatedDate");
					this.OnCreatedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastLoginDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> LastLoginDate
		{
			get
			{
				return this._LastLoginDate;
			}
			set
			{
				if ((this._LastLoginDate != value))
				{
					this.OnLastLoginDateChanging(value);
					this.SendPropertyChanging();
					this._LastLoginDate = value;
					this.SendPropertyChanged("LastLoginDate");
					this.OnLastLoginDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Role_Member", Storage="_Role", ThisKey="RoleId", OtherKey="Id", IsForeignKey=true)]
		public Role Role
		{
			get
			{
				return this._Role.Entity;
			}
			set
			{
				Role previousValue = this._Role.Entity;
				if (((previousValue != value) 
							|| (this._Role.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Role.Entity = null;
						previousValue.Members.Remove(this);
					}
					this._Role.Entity = value;
					if ((value != null))
					{
						value.Members.Add(this);
						this._RoleId = value.Id;
					}
					else
					{
						this._RoleId = default(int);
					}
					this.SendPropertyChanged("Role");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChoiceSets")]
	public partial class ChoiceSet : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Type;
		
		private EntitySet<Choice> _Choices;
		
		private EntitySet<Question> _Questions;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    #endregion
		
		public ChoiceSet()
		{
			this._Choices = new EntitySet<Choice>(new Action<Choice>(this.attach_Choices), new Action<Choice>(this.detach_Choices));
			this._Questions = new EntitySet<Question>(new Action<Question>(this.attach_Questions), new Action<Question>(this.detach_Questions));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="NVarChar(50)")]
		public string Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ChoiceSet_Choice", Storage="_Choices", ThisKey="Id", OtherKey="ChoiceSetId")]
		public EntitySet<Choice> Choices
		{
			get
			{
				return this._Choices;
			}
			set
			{
				this._Choices.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ChoiceSet_Question", Storage="_Questions", ThisKey="Id", OtherKey="ChoiceSetId")]
		public EntitySet<Question> Questions
		{
			get
			{
				return this._Questions;
			}
			set
			{
				this._Questions.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Choices(Choice entity)
		{
			this.SendPropertyChanging();
			entity.ChoiceSet = this;
		}
		
		private void detach_Choices(Choice entity)
		{
			this.SendPropertyChanging();
			entity.ChoiceSet = null;
		}
		
		private void attach_Questions(Question entity)
		{
			this.SendPropertyChanging();
			entity.ChoiceSet = this;
		}
		
		private void detach_Questions(Question entity)
		{
			this.SendPropertyChanging();
			entity.ChoiceSet = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Choices")]
	public partial class Choice : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _ChoiceSetId;
		
		private string _Content;
		
		private EntityRef<ChoiceSet> _ChoiceSet;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnChoiceSetIdChanging(System.Nullable<int> value);
    partial void OnChoiceSetIdChanged();
    partial void OnContentChanging(string value);
    partial void OnContentChanged();
    #endregion
		
		public Choice()
		{
			this._ChoiceSet = default(EntityRef<ChoiceSet>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChoiceSetId", DbType="Int")]
		public System.Nullable<int> ChoiceSetId
		{
			get
			{
				return this._ChoiceSetId;
			}
			set
			{
				if ((this._ChoiceSetId != value))
				{
					if (this._ChoiceSet.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnChoiceSetIdChanging(value);
					this.SendPropertyChanging();
					this._ChoiceSetId = value;
					this.SendPropertyChanged("ChoiceSetId");
					this.OnChoiceSetIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Content", DbType="NVarChar(50)")]
		public string Content
		{
			get
			{
				return this._Content;
			}
			set
			{
				if ((this._Content != value))
				{
					this.OnContentChanging(value);
					this.SendPropertyChanging();
					this._Content = value;
					this.SendPropertyChanged("Content");
					this.OnContentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ChoiceSet_Choice", Storage="_ChoiceSet", ThisKey="ChoiceSetId", OtherKey="Id", IsForeignKey=true)]
		public ChoiceSet ChoiceSet
		{
			get
			{
				return this._ChoiceSet.Entity;
			}
			set
			{
				ChoiceSet previousValue = this._ChoiceSet.Entity;
				if (((previousValue != value) 
							|| (this._ChoiceSet.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ChoiceSet.Entity = null;
						previousValue.Choices.Remove(this);
					}
					this._ChoiceSet.Entity = value;
					if ((value != null))
					{
						value.Choices.Add(this);
						this._ChoiceSetId = value.Id;
					}
					else
					{
						this._ChoiceSetId = default(Nullable<int>);
					}
					this.SendPropertyChanged("ChoiceSet");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Questions")]
	public partial class Question : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Content;
		
		private int _ChoiceSetId;
		
		private int _ChoiceCorrectId;
		
		private EntityRef<ChoiceSet> _ChoiceSet;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnContentChanging(string value);
    partial void OnContentChanged();
    partial void OnChoiceSetIdChanging(int value);
    partial void OnChoiceSetIdChanged();
    partial void OnChoiceCorrectIdChanging(int value);
    partial void OnChoiceCorrectIdChanged();
    #endregion
		
		public Question()
		{
			this._ChoiceSet = default(EntityRef<ChoiceSet>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Content", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Content
		{
			get
			{
				return this._Content;
			}
			set
			{
				if ((this._Content != value))
				{
					this.OnContentChanging(value);
					this.SendPropertyChanging();
					this._Content = value;
					this.SendPropertyChanged("Content");
					this.OnContentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChoiceSetId", DbType="Int NOT NULL")]
		public int ChoiceSetId
		{
			get
			{
				return this._ChoiceSetId;
			}
			set
			{
				if ((this._ChoiceSetId != value))
				{
					if (this._ChoiceSet.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnChoiceSetIdChanging(value);
					this.SendPropertyChanging();
					this._ChoiceSetId = value;
					this.SendPropertyChanged("ChoiceSetId");
					this.OnChoiceSetIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChoiceCorrectId", DbType="Int NOT NULL")]
		public int ChoiceCorrectId
		{
			get
			{
				return this._ChoiceCorrectId;
			}
			set
			{
				if ((this._ChoiceCorrectId != value))
				{
					this.OnChoiceCorrectIdChanging(value);
					this.SendPropertyChanging();
					this._ChoiceCorrectId = value;
					this.SendPropertyChanged("ChoiceCorrectId");
					this.OnChoiceCorrectIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ChoiceSet_Question", Storage="_ChoiceSet", ThisKey="ChoiceSetId", OtherKey="Id", IsForeignKey=true)]
		public ChoiceSet ChoiceSet
		{
			get
			{
				return this._ChoiceSet.Entity;
			}
			set
			{
				ChoiceSet previousValue = this._ChoiceSet.Entity;
				if (((previousValue != value) 
							|| (this._ChoiceSet.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ChoiceSet.Entity = null;
						previousValue.Questions.Remove(this);
					}
					this._ChoiceSet.Entity = value;
					if ((value != null))
					{
						value.Questions.Add(this);
						this._ChoiceSetId = value.Id;
					}
					else
					{
						this._ChoiceSetId = default(int);
					}
					this.SendPropertyChanged("ChoiceSet");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.QuestionResults")]
	public partial class QuestionResult
	{
		
		private int _StudentId;
		
		private System.Nullable<int> _QuestionId;
		
		private System.Nullable<int> _ChoiceId;
		
		private System.Nullable<bool> _IsCorrect;
		
		public QuestionResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentId", DbType="Int NOT NULL")]
		public int StudentId
		{
			get
			{
				return this._StudentId;
			}
			set
			{
				if ((this._StudentId != value))
				{
					this._StudentId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuestionId", DbType="Int")]
		public System.Nullable<int> QuestionId
		{
			get
			{
				return this._QuestionId;
			}
			set
			{
				if ((this._QuestionId != value))
				{
					this._QuestionId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChoiceId", DbType="Int")]
		public System.Nullable<int> ChoiceId
		{
			get
			{
				return this._ChoiceId;
			}
			set
			{
				if ((this._ChoiceId != value))
				{
					this._ChoiceId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsCorrect", DbType="Bit")]
		public System.Nullable<bool> IsCorrect
		{
			get
			{
				return this._IsCorrect;
			}
			set
			{
				if ((this._IsCorrect != value))
				{
					this._IsCorrect = value;
				}
			}
		}
	}
}
#pragma warning restore 1591