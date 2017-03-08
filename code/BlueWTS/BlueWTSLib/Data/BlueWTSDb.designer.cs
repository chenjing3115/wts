﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueWTSLib.Data
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BlueWTS")]
	public partial class BlueWTSDbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertSysRoleTypeAuthorization(SysRoleTypeAuthorization instance);
    partial void UpdateSysRoleTypeAuthorization(SysRoleTypeAuthorization instance);
    partial void DeleteSysRoleTypeAuthorization(SysRoleTypeAuthorization instance);
    partial void InsertSysAuthorization(SysAuthorization instance);
    partial void UpdateSysAuthorization(SysAuthorization instance);
    partial void DeleteSysAuthorization(SysAuthorization instance);
    #endregion
		
		public BlueWTSDbDataContext() : 
				base(global::BlueWTSLib.Properties.Settings.Default.BlueWTSConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BlueWTSDbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BlueWTSDbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BlueWTSDbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BlueWTSDbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<User> User
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<SysRoleTypeAuthorization> SysRoleTypeAuthorization
		{
			get
			{
				return this.GetTable<SysRoleTypeAuthorization>();
			}
		}
		
		public System.Data.Linq.Table<SysAuthorization> SysAuthorization
		{
			get
			{
				return this.GetTable<SysAuthorization>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _nr;
		
		private string _name;
		
		private string _email;
		
		private string _pwd;
		
		private string _pwdSalt;
		
		private string _wxOpenId;
		
		private string _wx_access_token;
		
		private System.Nullable<int> _wx_access_token_expires_in;
		
		private string _wx_refresh_token;
		
		private string _wx_scope;
		
		private string _phone;
		
		private System.Nullable<int> _roleType;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnrChanging(string value);
    partial void OnnrChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnpwdChanging(string value);
    partial void OnpwdChanged();
    partial void OnpwdSaltChanging(string value);
    partial void OnpwdSaltChanged();
    partial void OnwxOpenIdChanging(string value);
    partial void OnwxOpenIdChanged();
    partial void Onwx_access_tokenChanging(string value);
    partial void Onwx_access_tokenChanged();
    partial void Onwx_access_token_expires_inChanging(System.Nullable<int> value);
    partial void Onwx_access_token_expires_inChanged();
    partial void Onwx_refresh_tokenChanging(string value);
    partial void Onwx_refresh_tokenChanged();
    partial void Onwx_scopeChanging(string value);
    partial void Onwx_scopeChanged();
    partial void OnphoneChanging(string value);
    partial void OnphoneChanged();
    partial void OnroleTypeChanging(System.Nullable<int> value);
    partial void OnroleTypeChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nr", DbType="VarChar(50)")]
		public string nr
		{
			get
			{
				return this._nr;
			}
			set
			{
				if ((this._nr != value))
				{
					this.OnnrChanging(value);
					this.SendPropertyChanging();
					this._nr = value;
					this.SendPropertyChanged("nr");
					this.OnnrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(50)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pwd", DbType="NVarChar(100)")]
		public string pwd
		{
			get
			{
				return this._pwd;
			}
			set
			{
				if ((this._pwd != value))
				{
					this.OnpwdChanging(value);
					this.SendPropertyChanging();
					this._pwd = value;
					this.SendPropertyChanged("pwd");
					this.OnpwdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pwdSalt", DbType="VarChar(100)")]
		public string pwdSalt
		{
			get
			{
				return this._pwdSalt;
			}
			set
			{
				if ((this._pwdSalt != value))
				{
					this.OnpwdSaltChanging(value);
					this.SendPropertyChanging();
					this._pwdSalt = value;
					this.SendPropertyChanged("pwdSalt");
					this.OnpwdSaltChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_wxOpenId", DbType="VarChar(50)")]
		public string wxOpenId
		{
			get
			{
				return this._wxOpenId;
			}
			set
			{
				if ((this._wxOpenId != value))
				{
					this.OnwxOpenIdChanging(value);
					this.SendPropertyChanging();
					this._wxOpenId = value;
					this.SendPropertyChanged("wxOpenId");
					this.OnwxOpenIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_wx_access_token", DbType="VarChar(50)")]
		public string wx_access_token
		{
			get
			{
				return this._wx_access_token;
			}
			set
			{
				if ((this._wx_access_token != value))
				{
					this.Onwx_access_tokenChanging(value);
					this.SendPropertyChanging();
					this._wx_access_token = value;
					this.SendPropertyChanged("wx_access_token");
					this.Onwx_access_tokenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_wx_access_token_expires_in", DbType="Int")]
		public System.Nullable<int> wx_access_token_expires_in
		{
			get
			{
				return this._wx_access_token_expires_in;
			}
			set
			{
				if ((this._wx_access_token_expires_in != value))
				{
					this.Onwx_access_token_expires_inChanging(value);
					this.SendPropertyChanging();
					this._wx_access_token_expires_in = value;
					this.SendPropertyChanged("wx_access_token_expires_in");
					this.Onwx_access_token_expires_inChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_wx_refresh_token", DbType="VarChar(50)")]
		public string wx_refresh_token
		{
			get
			{
				return this._wx_refresh_token;
			}
			set
			{
				if ((this._wx_refresh_token != value))
				{
					this.Onwx_refresh_tokenChanging(value);
					this.SendPropertyChanging();
					this._wx_refresh_token = value;
					this.SendPropertyChanged("wx_refresh_token");
					this.Onwx_refresh_tokenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_wx_scope", DbType="VarChar(50)")]
		public string wx_scope
		{
			get
			{
				return this._wx_scope;
			}
			set
			{
				if ((this._wx_scope != value))
				{
					this.Onwx_scopeChanging(value);
					this.SendPropertyChanging();
					this._wx_scope = value;
					this.SendPropertyChanged("wx_scope");
					this.Onwx_scopeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone", DbType="VarChar(50)")]
		public string phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this.OnphoneChanging(value);
					this.SendPropertyChanging();
					this._phone = value;
					this.SendPropertyChanged("phone");
					this.OnphoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_roleType", DbType="Int")]
		public System.Nullable<int> roleType
		{
			get
			{
				return this._roleType;
			}
			set
			{
				if ((this._roleType != value))
				{
					this.OnroleTypeChanging(value);
					this.SendPropertyChanging();
					this._roleType = value;
					this.SendPropertyChanged("roleType");
					this.OnroleTypeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SysRoleTypeAuthorization")]
	public partial class SysRoleTypeAuthorization : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.Nullable<int> _roleType;
		
		private System.Nullable<int> _sysAuthorizationId;
		
		private string _remarks;
		
		private EntityRef<SysAuthorization> _SysAuthorization;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnroleTypeChanging(System.Nullable<int> value);
    partial void OnroleTypeChanged();
    partial void OnsysAuthorizationIdChanging(System.Nullable<int> value);
    partial void OnsysAuthorizationIdChanged();
    partial void OnremarksChanging(string value);
    partial void OnremarksChanged();
    #endregion
		
		public SysRoleTypeAuthorization()
		{
			this._SysAuthorization = default(EntityRef<SysAuthorization>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_roleType", DbType="Int")]
		public System.Nullable<int> roleType
		{
			get
			{
				return this._roleType;
			}
			set
			{
				if ((this._roleType != value))
				{
					this.OnroleTypeChanging(value);
					this.SendPropertyChanging();
					this._roleType = value;
					this.SendPropertyChanged("roleType");
					this.OnroleTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sysAuthorizationId", DbType="Int")]
		public System.Nullable<int> sysAuthorizationId
		{
			get
			{
				return this._sysAuthorizationId;
			}
			set
			{
				if ((this._sysAuthorizationId != value))
				{
					if (this._SysAuthorization.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnsysAuthorizationIdChanging(value);
					this.SendPropertyChanging();
					this._sysAuthorizationId = value;
					this.SendPropertyChanged("sysAuthorizationId");
					this.OnsysAuthorizationIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_remarks", DbType="NVarChar(200)")]
		public string remarks
		{
			get
			{
				return this._remarks;
			}
			set
			{
				if ((this._remarks != value))
				{
					this.OnremarksChanging(value);
					this.SendPropertyChanging();
					this._remarks = value;
					this.SendPropertyChanged("remarks");
					this.OnremarksChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SysAuthorization_SysRoleTypeAuthorization", Storage="_SysAuthorization", ThisKey="sysAuthorizationId", OtherKey="id", IsForeignKey=true)]
		public SysAuthorization SysAuthorization
		{
			get
			{
				return this._SysAuthorization.Entity;
			}
			set
			{
				SysAuthorization previousValue = this._SysAuthorization.Entity;
				if (((previousValue != value) 
							|| (this._SysAuthorization.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SysAuthorization.Entity = null;
						previousValue.SysRoleTypeAuthorization.Remove(this);
					}
					this._SysAuthorization.Entity = value;
					if ((value != null))
					{
						value.SysRoleTypeAuthorization.Add(this);
						this._sysAuthorizationId = value.id;
					}
					else
					{
						this._sysAuthorizationId = default(Nullable<int>);
					}
					this.SendPropertyChanged("SysAuthorization");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SysAuthorization")]
	public partial class SysAuthorization : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private string _controller;
		
		private string _action;
		
		private System.Nullable<int> _parentId;
		
		private string _code;
		
		private string _remarks;
		
		private EntitySet<SysRoleTypeAuthorization> _SysRoleTypeAuthorization;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OncontrollerChanging(string value);
    partial void OncontrollerChanged();
    partial void OnactionChanging(string value);
    partial void OnactionChanged();
    partial void OnparentIdChanging(System.Nullable<int> value);
    partial void OnparentIdChanged();
    partial void OncodeChanging(string value);
    partial void OncodeChanged();
    partial void OnremarksChanging(string value);
    partial void OnremarksChanged();
    #endregion
		
		public SysAuthorization()
		{
			this._SysRoleTypeAuthorization = new EntitySet<SysRoleTypeAuthorization>(new Action<SysRoleTypeAuthorization>(this.attach_SysRoleTypeAuthorization), new Action<SysRoleTypeAuthorization>(this.detach_SysRoleTypeAuthorization));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_controller", DbType="NVarChar(50)")]
		public string controller
		{
			get
			{
				return this._controller;
			}
			set
			{
				if ((this._controller != value))
				{
					this.OncontrollerChanging(value);
					this.SendPropertyChanging();
					this._controller = value;
					this.SendPropertyChanged("controller");
					this.OncontrollerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_action", DbType="NVarChar(50)")]
		public string action
		{
			get
			{
				return this._action;
			}
			set
			{
				if ((this._action != value))
				{
					this.OnactionChanging(value);
					this.SendPropertyChanging();
					this._action = value;
					this.SendPropertyChanged("action");
					this.OnactionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_parentId", DbType="Int")]
		public System.Nullable<int> parentId
		{
			get
			{
				return this._parentId;
			}
			set
			{
				if ((this._parentId != value))
				{
					this.OnparentIdChanging(value);
					this.SendPropertyChanging();
					this._parentId = value;
					this.SendPropertyChanged("parentId");
					this.OnparentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_code", DbType="NVarChar(50)")]
		public string code
		{
			get
			{
				return this._code;
			}
			set
			{
				if ((this._code != value))
				{
					this.OncodeChanging(value);
					this.SendPropertyChanging();
					this._code = value;
					this.SendPropertyChanged("code");
					this.OncodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_remarks", DbType="NVarChar(200)")]
		public string remarks
		{
			get
			{
				return this._remarks;
			}
			set
			{
				if ((this._remarks != value))
				{
					this.OnremarksChanging(value);
					this.SendPropertyChanging();
					this._remarks = value;
					this.SendPropertyChanged("remarks");
					this.OnremarksChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SysAuthorization_SysRoleTypeAuthorization", Storage="_SysRoleTypeAuthorization", ThisKey="id", OtherKey="sysAuthorizationId")]
		public EntitySet<SysRoleTypeAuthorization> SysRoleTypeAuthorization
		{
			get
			{
				return this._SysRoleTypeAuthorization;
			}
			set
			{
				this._SysRoleTypeAuthorization.Assign(value);
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
		
		private void attach_SysRoleTypeAuthorization(SysRoleTypeAuthorization entity)
		{
			this.SendPropertyChanging();
			entity.SysAuthorization = this;
		}
		
		private void detach_SysRoleTypeAuthorization(SysRoleTypeAuthorization entity)
		{
			this.SendPropertyChanging();
			entity.SysAuthorization = null;
		}
	}
}
#pragma warning restore 1591