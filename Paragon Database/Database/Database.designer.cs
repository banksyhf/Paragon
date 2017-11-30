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

namespace Paragon_Database.Database
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="paragon")]
	public partial class ParagonDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertThread(Thread instance);
    partial void UpdateThread(Thread instance);
    partial void DeleteThread(Thread instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public ParagonDataContext() : 
				base(global::Paragon_Database.Properties.Settings.Default.paragonConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ParagonDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ParagonDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ParagonDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ParagonDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Thread> Threads
		{
			get
			{
				return this.GetTable<Thread>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Thread")]
	public partial class Thread : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ThreadID;
		
		private int _ForumID;
		
		private int _AuthorUID;
		
		private bool _IsSticky;
		
		private System.DateTime _PostTime;
		
		private System.Nullable<System.DateTime> _EditTime;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnThreadIDChanging(int value);
    partial void OnThreadIDChanged();
    partial void OnForumIDChanging(int value);
    partial void OnForumIDChanged();
    partial void OnAuthorUIDChanging(int value);
    partial void OnAuthorUIDChanged();
    partial void OnIsStickyChanging(bool value);
    partial void OnIsStickyChanged();
    partial void OnPostTimeChanging(System.DateTime value);
    partial void OnPostTimeChanged();
    partial void OnEditTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnEditTimeChanged();
    #endregion
		
		public Thread()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThreadID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ThreadID
		{
			get
			{
				return this._ThreadID;
			}
			set
			{
				if ((this._ThreadID != value))
				{
					this.OnThreadIDChanging(value);
					this.SendPropertyChanging();
					this._ThreadID = value;
					this.SendPropertyChanged("ThreadID");
					this.OnThreadIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ForumID", DbType="Int NOT NULL")]
		public int ForumID
		{
			get
			{
				return this._ForumID;
			}
			set
			{
				if ((this._ForumID != value))
				{
					this.OnForumIDChanging(value);
					this.SendPropertyChanging();
					this._ForumID = value;
					this.SendPropertyChanged("ForumID");
					this.OnForumIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AuthorUID", DbType="Int NOT NULL")]
		public int AuthorUID
		{
			get
			{
				return this._AuthorUID;
			}
			set
			{
				if ((this._AuthorUID != value))
				{
					this.OnAuthorUIDChanging(value);
					this.SendPropertyChanging();
					this._AuthorUID = value;
					this.SendPropertyChanged("AuthorUID");
					this.OnAuthorUIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsSticky", DbType="Bit NOT NULL")]
		public bool IsSticky
		{
			get
			{
				return this._IsSticky;
			}
			set
			{
				if ((this._IsSticky != value))
				{
					this.OnIsStickyChanging(value);
					this.SendPropertyChanging();
					this._IsSticky = value;
					this.SendPropertyChanged("IsSticky");
					this.OnIsStickyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostTime", DbType="DateTime NOT NULL")]
		public System.DateTime PostTime
		{
			get
			{
				return this._PostTime;
			}
			set
			{
				if ((this._PostTime != value))
				{
					this.OnPostTimeChanging(value);
					this.SendPropertyChanging();
					this._PostTime = value;
					this.SendPropertyChanged("PostTime");
					this.OnPostTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EditTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> EditTime
		{
			get
			{
				return this._EditTime;
			}
			set
			{
				if ((this._EditTime != value))
				{
					this.OnEditTimeChanging(value);
					this.SendPropertyChanging();
					this._EditTime = value;
					this.SendPropertyChanged("EditTime");
					this.OnEditTimeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UID;
		
		private string _Username;
		
		private string _Password;
		
		private string _Hash;
		
		private string _Email;
		
		private string _Avatar;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUIDChanging(int value);
    partial void OnUIDChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnHashChanging(string value);
    partial void OnHashChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnAvatarChanging(string value);
    partial void OnAvatarChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UID", DbType="Int NOT NULL", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UID
		{
			get
			{
				return this._UID;
			}
			set
			{
				if ((this._UID != value))
				{
					this.OnUIDChanging(value);
					this.SendPropertyChanging();
					this._UID = value;
					this.SendPropertyChanged("UID");
					this.OnUIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(16) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(64) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hash", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Hash
		{
			get
			{
				return this._Hash;
			}
			set
			{
				if ((this._Hash != value))
				{
					this.OnHashChanging(value);
					this.SendPropertyChanging();
					this._Hash = value;
					this.SendPropertyChanged("Hash");
					this.OnHashChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Avatar", DbType="NVarChar(100)")]
		public string Avatar
		{
			get
			{
				return this._Avatar;
			}
			set
			{
				if ((this._Avatar != value))
				{
					this.OnAvatarChanging(value);
					this.SendPropertyChanging();
					this._Avatar = value;
					this.SendPropertyChanged("Avatar");
					this.OnAvatarChanged();
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
}
#pragma warning restore 1591
