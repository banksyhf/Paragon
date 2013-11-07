﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Paragon_Database
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
	
	
	public partial class ParagonDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertThread(Thread instance);
    partial void UpdateThread(Thread instance);
    partial void DeleteThread(Thread instance);
    #endregion
		
		public ParagonDataContext() : 
				base(global::Paragon_Database.Properties.Settings.Default.ConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Thread> Threads
		{
			get
			{
				return this.GetTable<Thread>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UID = default(int);
		
		private string _Username;
		
		private string _Password;
		
		private string _Hash;
		
		private string _Avatar;
		
		private string _Email;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnHashChanging(string value);
    partial void OnHashChanged();
    partial void OnAvatarChanging(string value);
    partial void OnAvatarChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="uid", Storage="_UID", AutoSync=AutoSync.OnInsert, IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public int UID
		{
			get
			{
				return this._UID;
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="username", Storage="_Username", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="password", Storage="_Password", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="hash", Storage="_Hash", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="avatar", Storage="_Avatar", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="email", Storage="_Email", CanBeNull=false)]
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class Thread : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UID = default(int);
		
		private int _Username;
		
		private string _Password;
		
		private bool _Email;
		
		private System.DateTime _PostTime;
		
		private System.DateTime _EditTime;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnForumIDChanging(int value);
    partial void OnForumIDChanged();
    partial void OnAuthorChanging(string value);
    partial void OnAuthorChanged();
    partial void OnIsStickyChanging(bool value);
    partial void OnIsStickyChanged();
    partial void OnPostTimeChanging(System.DateTime value);
    partial void OnPostTimeChanged();
    partial void OnEditTimeChanging(System.DateTime value);
    partial void OnEditTimeChanged();
    #endregion
		
		public Thread()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="tid", Storage="_UID", AutoSync=AutoSync.OnInsert, IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public int ThreadID
		{
			get
			{
				return this._UID;
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="fid", Storage="_Username")]
		public int ForumID
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnForumIDChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("ForumID");
					this.OnForumIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="author", Storage="_Password", CanBeNull=false)]
		public string Author
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnAuthorChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Author");
					this.OnAuthorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="sticky", Storage="_Email")]
		public bool IsSticky
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnIsStickyChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("IsSticky");
					this.OnIsStickyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="posttime", Storage="_PostTime")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="edittime", Storage="_EditTime", IsDbGenerated=true, IsVersion=true)]
		public System.DateTime EditTime
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
}
#pragma warning restore 1591
