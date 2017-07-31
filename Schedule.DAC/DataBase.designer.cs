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

namespace Schedule.DAC
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Schedule")]
	public partial class DataBaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEvent(Event instance);
    partial void UpdateEvent(Event instance);
    partial void DeleteEvent(Event instance);
    partial void InsertNewsV(NewsV instance);
    partial void UpdateNewsV(NewsV instance);
    partial void DeleteNewsV(NewsV instance);
    partial void InsertFinalNew(FinalNew instance);
    partial void UpdateFinalNew(FinalNew instance);
    partial void DeleteFinalNew(FinalNew instance);
    partial void InsertFinalNewsImage(FinalNewsImage instance);
    partial void UpdateFinalNewsImage(FinalNewsImage instance);
    partial void DeleteFinalNewsImage(FinalNewsImage instance);
    partial void InsertImage(Image instance);
    partial void UpdateImage(Image instance);
    partial void DeleteImage(Image instance);
    partial void InsertMainNew(MainNew instance);
    partial void UpdateMainNew(MainNew instance);
    partial void DeleteMainNew(MainNew instance);
    partial void InsertNew(New instance);
    partial void UpdateNew(New instance);
    partial void DeleteNew(New instance);
    partial void InsertNewsImage(NewsImage instance);
    partial void UpdateNewsImage(NewsImage instance);
    partial void DeleteNewsImage(NewsImage instance);
    partial void InsertNewsOld(NewsOld instance);
    partial void UpdateNewsOld(NewsOld instance);
    partial void DeleteNewsOld(NewsOld instance);
    #endregion
		
		public DataBaseDataContext() : 
				base(global::Schedule.DAC.Properties.Settings.Default.ScheduleConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Event> Events
		{
			get
			{
				return this.GetTable<Event>();
			}
		}
		
		public System.Data.Linq.Table<NewsV> NewsVs
		{
			get
			{
				return this.GetTable<NewsV>();
			}
		}
		
		public System.Data.Linq.Table<FinalNew> FinalNews
		{
			get
			{
				return this.GetTable<FinalNew>();
			}
		}
		
		public System.Data.Linq.Table<FinalNewsImage> FinalNewsImages
		{
			get
			{
				return this.GetTable<FinalNewsImage>();
			}
		}
		
		public System.Data.Linq.Table<Image> Images
		{
			get
			{
				return this.GetTable<Image>();
			}
		}
		
		public System.Data.Linq.Table<MainNew> MainNews
		{
			get
			{
				return this.GetTable<MainNew>();
			}
		}
		
		public System.Data.Linq.Table<New> News
		{
			get
			{
				return this.GetTable<New>();
			}
		}
		
		public System.Data.Linq.Table<NewsImage> NewsImages
		{
			get
			{
				return this.GetTable<NewsImage>();
			}
		}
		
		public System.Data.Linq.Table<NewsOld> NewsOlds
		{
			get
			{
				return this.GetTable<NewsOld>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Event")]
	public partial class Event : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Title;
		
		private string _Additional;
		
		private System.DateTime _StartDate;
		
		private System.DateTime _EndDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnAdditionalChanging(string value);
    partial void OnAdditionalChanged();
    partial void OnStartDateChanging(System.DateTime value);
    partial void OnStartDateChanged();
    partial void OnEndDateChanging(System.DateTime value);
    partial void OnEndDateChanged();
    #endregion
		
		public Event()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Additional", DbType="NVarChar(300) NOT NULL", CanBeNull=false)]
		public string Additional
		{
			get
			{
				return this._Additional;
			}
			set
			{
				if ((this._Additional != value))
				{
					this.OnAdditionalChanging(value);
					this.SendPropertyChanging();
					this._Additional = value;
					this.SendPropertyChanged("Additional");
					this.OnAdditionalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartDate", DbType="SmallDateTime NOT NULL")]
		public System.DateTime StartDate
		{
			get
			{
				return this._StartDate;
			}
			set
			{
				if ((this._StartDate != value))
				{
					this.OnStartDateChanging(value);
					this.SendPropertyChanging();
					this._StartDate = value;
					this.SendPropertyChanged("StartDate");
					this.OnStartDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndDate", DbType="SmallDateTime NOT NULL")]
		public System.DateTime EndDate
		{
			get
			{
				return this._EndDate;
			}
			set
			{
				if ((this._EndDate != value))
				{
					this.OnEndDateChanging(value);
					this.SendPropertyChanging();
					this._EndDate = value;
					this.SendPropertyChanged("EndDate");
					this.OnEndDateChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NewsV")]
	public partial class NewsV : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Title;
		
		private string _Body;
		
		private EntitySet<NewsImage> _NewsImages;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnBodyChanging(string value);
    partial void OnBodyChanged();
    #endregion
		
		public NewsV()
		{
			this._NewsImages = new EntitySet<NewsImage>(new Action<NewsImage>(this.attach_NewsImages), new Action<NewsImage>(this.detach_NewsImages));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(60) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Body", DbType="NVarChar(410) NOT NULL", CanBeNull=false)]
		public string Body
		{
			get
			{
				return this._Body;
			}
			set
			{
				if ((this._Body != value))
				{
					this.OnBodyChanging(value);
					this.SendPropertyChanging();
					this._Body = value;
					this.SendPropertyChanged("Body");
					this.OnBodyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NewsV_NewsImage", Storage="_NewsImages", ThisKey="Id", OtherKey="NewsId")]
		public EntitySet<NewsImage> NewsImages
		{
			get
			{
				return this._NewsImages;
			}
			set
			{
				this._NewsImages.Assign(value);
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
		
		private void attach_NewsImages(NewsImage entity)
		{
			this.SendPropertyChanging();
			entity.NewsV = this;
		}
		
		private void detach_NewsImages(NewsImage entity)
		{
			this.SendPropertyChanging();
			entity.NewsV = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.FinalNews")]
	public partial class FinalNew : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _ShortTitle;
		
		private string _FullTitle;
		
		private string _ShortArticle;
		
		private string _FullArticle;
		
		private EntitySet<FinalNewsImage> _FinalNewsImages;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnShortTitleChanging(string value);
    partial void OnShortTitleChanged();
    partial void OnFullTitleChanging(string value);
    partial void OnFullTitleChanged();
    partial void OnShortArticleChanging(string value);
    partial void OnShortArticleChanged();
    partial void OnFullArticleChanging(string value);
    partial void OnFullArticleChanged();
    #endregion
		
		public FinalNew()
		{
			this._FinalNewsImages = new EntitySet<FinalNewsImage>(new Action<FinalNewsImage>(this.attach_FinalNewsImages), new Action<FinalNewsImage>(this.detach_FinalNewsImages));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShortTitle", DbType="NVarChar(60) NOT NULL", CanBeNull=false)]
		public string ShortTitle
		{
			get
			{
				return this._ShortTitle;
			}
			set
			{
				if ((this._ShortTitle != value))
				{
					this.OnShortTitleChanging(value);
					this.SendPropertyChanging();
					this._ShortTitle = value;
					this.SendPropertyChanged("ShortTitle");
					this.OnShortTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullTitle", DbType="NVarChar(256) NOT NULL", CanBeNull=false)]
		public string FullTitle
		{
			get
			{
				return this._FullTitle;
			}
			set
			{
				if ((this._FullTitle != value))
				{
					this.OnFullTitleChanging(value);
					this.SendPropertyChanging();
					this._FullTitle = value;
					this.SendPropertyChanged("FullTitle");
					this.OnFullTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShortArticle", DbType="NVarChar(410) NOT NULL", CanBeNull=false)]
		public string ShortArticle
		{
			get
			{
				return this._ShortArticle;
			}
			set
			{
				if ((this._ShortArticle != value))
				{
					this.OnShortArticleChanging(value);
					this.SendPropertyChanging();
					this._ShortArticle = value;
					this.SendPropertyChanged("ShortArticle");
					this.OnShortArticleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullArticle", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string FullArticle
		{
			get
			{
				return this._FullArticle;
			}
			set
			{
				if ((this._FullArticle != value))
				{
					this.OnFullArticleChanging(value);
					this.SendPropertyChanging();
					this._FullArticle = value;
					this.SendPropertyChanged("FullArticle");
					this.OnFullArticleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FinalNew_FinalNewsImage", Storage="_FinalNewsImages", ThisKey="Id", OtherKey="NewsId")]
		public EntitySet<FinalNewsImage> FinalNewsImages
		{
			get
			{
				return this._FinalNewsImages;
			}
			set
			{
				this._FinalNewsImages.Assign(value);
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
		
		private void attach_FinalNewsImages(FinalNewsImage entity)
		{
			this.SendPropertyChanging();
			entity.FinalNew = this;
		}
		
		private void detach_FinalNewsImages(FinalNewsImage entity)
		{
			this.SendPropertyChanging();
			entity.FinalNew = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.FinalNewsImages")]
	public partial class FinalNewsImage : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Data.Linq.Binary _ImageItem;
		
		private int _NewsId;
		
		private EntityRef<FinalNew> _FinalNew;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnImageItemChanging(System.Data.Linq.Binary value);
    partial void OnImageItemChanged();
    partial void OnNewsIdChanging(int value);
    partial void OnNewsIdChanged();
    #endregion
		
		public FinalNewsImage()
		{
			this._FinalNew = default(EntityRef<FinalNew>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageItem", DbType="VarBinary(MAX) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary ImageItem
		{
			get
			{
				return this._ImageItem;
			}
			set
			{
				if ((this._ImageItem != value))
				{
					this.OnImageItemChanging(value);
					this.SendPropertyChanging();
					this._ImageItem = value;
					this.SendPropertyChanged("ImageItem");
					this.OnImageItemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NewsId", DbType="Int NOT NULL")]
		public int NewsId
		{
			get
			{
				return this._NewsId;
			}
			set
			{
				if ((this._NewsId != value))
				{
					if (this._FinalNew.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnNewsIdChanging(value);
					this.SendPropertyChanging();
					this._NewsId = value;
					this.SendPropertyChanged("NewsId");
					this.OnNewsIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FinalNew_FinalNewsImage", Storage="_FinalNew", ThisKey="NewsId", OtherKey="Id", IsForeignKey=true)]
		public FinalNew FinalNew
		{
			get
			{
				return this._FinalNew.Entity;
			}
			set
			{
				FinalNew previousValue = this._FinalNew.Entity;
				if (((previousValue != value) 
							|| (this._FinalNew.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._FinalNew.Entity = null;
						previousValue.FinalNewsImages.Remove(this);
					}
					this._FinalNew.Entity = value;
					if ((value != null))
					{
						value.FinalNewsImages.Add(this);
						this._NewsId = value.Id;
					}
					else
					{
						this._NewsId = default(int);
					}
					this.SendPropertyChanged("FinalNew");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Image")]
	public partial class Image : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Data.Linq.Binary _ImageItem;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnImageItemChanging(System.Data.Linq.Binary value);
    partial void OnImageItemChanged();
    #endregion
		
		public Image()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageItem", DbType="VarBinary(MAX) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary ImageItem
		{
			get
			{
				return this._ImageItem;
			}
			set
			{
				if ((this._ImageItem != value))
				{
					this.OnImageItemChanging(value);
					this.SendPropertyChanging();
					this._ImageItem = value;
					this.SendPropertyChanged("ImageItem");
					this.OnImageItemChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MainNews")]
	public partial class MainNew : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _ShortTitle;
		
		private string _FullTitle;
		
		private System.Data.Linq.Binary _Image;
		
		private string _ShortArticle;
		
		private string _FullArticle;
		
		private System.DateTime _Date;
		
		private string _Author;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnShortTitleChanging(string value);
    partial void OnShortTitleChanged();
    partial void OnFullTitleChanging(string value);
    partial void OnFullTitleChanged();
    partial void OnImageChanging(System.Data.Linq.Binary value);
    partial void OnImageChanged();
    partial void OnShortArticleChanging(string value);
    partial void OnShortArticleChanged();
    partial void OnFullArticleChanging(string value);
    partial void OnFullArticleChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnAuthorChanging(string value);
    partial void OnAuthorChanged();
    #endregion
		
		public MainNew()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShortTitle", DbType="NVarChar(60) NOT NULL", CanBeNull=false)]
		public string ShortTitle
		{
			get
			{
				return this._ShortTitle;
			}
			set
			{
				if ((this._ShortTitle != value))
				{
					this.OnShortTitleChanging(value);
					this.SendPropertyChanging();
					this._ShortTitle = value;
					this.SendPropertyChanged("ShortTitle");
					this.OnShortTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullTitle", DbType="NVarChar(256) NOT NULL", CanBeNull=false)]
		public string FullTitle
		{
			get
			{
				return this._FullTitle;
			}
			set
			{
				if ((this._FullTitle != value))
				{
					this.OnFullTitleChanging(value);
					this.SendPropertyChanging();
					this._FullTitle = value;
					this.SendPropertyChanged("FullTitle");
					this.OnFullTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="VarBinary(MAX) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if ((this._Image != value))
				{
					this.OnImageChanging(value);
					this.SendPropertyChanging();
					this._Image = value;
					this.SendPropertyChanged("Image");
					this.OnImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShortArticle", DbType="NVarChar(410) NOT NULL", CanBeNull=false)]
		public string ShortArticle
		{
			get
			{
				return this._ShortArticle;
			}
			set
			{
				if ((this._ShortArticle != value))
				{
					this.OnShortArticleChanging(value);
					this.SendPropertyChanging();
					this._ShortArticle = value;
					this.SendPropertyChanged("ShortArticle");
					this.OnShortArticleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullArticle", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string FullArticle
		{
			get
			{
				return this._FullArticle;
			}
			set
			{
				if ((this._FullArticle != value))
				{
					this.OnFullArticleChanging(value);
					this.SendPropertyChanging();
					this._FullArticle = value;
					this.SendPropertyChanged("FullArticle");
					this.OnFullArticleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Author", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Author
		{
			get
			{
				return this._Author;
			}
			set
			{
				if ((this._Author != value))
				{
					this.OnAuthorChanging(value);
					this.SendPropertyChanging();
					this._Author = value;
					this.SendPropertyChanged("Author");
					this.OnAuthorChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.News")]
	public partial class New : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Title;
		
		private string _ImageLink;
		
		private string _Body;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnImageLinkChanging(string value);
    partial void OnImageLinkChanged();
    partial void OnBodyChanging(string value);
    partial void OnBodyChanged();
    #endregion
		
		public New()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(60) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageLink", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string ImageLink
		{
			get
			{
				return this._ImageLink;
			}
			set
			{
				if ((this._ImageLink != value))
				{
					this.OnImageLinkChanging(value);
					this.SendPropertyChanging();
					this._ImageLink = value;
					this.SendPropertyChanged("ImageLink");
					this.OnImageLinkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Body", DbType="NVarChar(410) NOT NULL", CanBeNull=false)]
		public string Body
		{
			get
			{
				return this._Body;
			}
			set
			{
				if ((this._Body != value))
				{
					this.OnBodyChanging(value);
					this.SendPropertyChanging();
					this._Body = value;
					this.SendPropertyChanged("Body");
					this.OnBodyChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NewsImage")]
	public partial class NewsImage : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Data.Linq.Binary _ImageItem;
		
		private int _NewsId;
		
		private EntityRef<NewsV> _NewsV;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnImageItemChanging(System.Data.Linq.Binary value);
    partial void OnImageItemChanged();
    partial void OnNewsIdChanging(int value);
    partial void OnNewsIdChanged();
    #endregion
		
		public NewsImage()
		{
			this._NewsV = default(EntityRef<NewsV>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageItem", DbType="VarBinary(MAX) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary ImageItem
		{
			get
			{
				return this._ImageItem;
			}
			set
			{
				if ((this._ImageItem != value))
				{
					this.OnImageItemChanging(value);
					this.SendPropertyChanging();
					this._ImageItem = value;
					this.SendPropertyChanged("ImageItem");
					this.OnImageItemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NewsId", DbType="Int NOT NULL")]
		public int NewsId
		{
			get
			{
				return this._NewsId;
			}
			set
			{
				if ((this._NewsId != value))
				{
					if (this._NewsV.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnNewsIdChanging(value);
					this.SendPropertyChanging();
					this._NewsId = value;
					this.SendPropertyChanged("NewsId");
					this.OnNewsIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NewsV_NewsImage", Storage="_NewsV", ThisKey="NewsId", OtherKey="Id", IsForeignKey=true)]
		public NewsV NewsV
		{
			get
			{
				return this._NewsV.Entity;
			}
			set
			{
				NewsV previousValue = this._NewsV.Entity;
				if (((previousValue != value) 
							|| (this._NewsV.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NewsV.Entity = null;
						previousValue.NewsImages.Remove(this);
					}
					this._NewsV.Entity = value;
					if ((value != null))
					{
						value.NewsImages.Add(this);
						this._NewsId = value.Id;
					}
					else
					{
						this._NewsId = default(int);
					}
					this.SendPropertyChanged("NewsV");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NewsOld")]
	public partial class NewsOld : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Title;
		
		private string _Body;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnBodyChanging(string value);
    partial void OnBodyChanged();
    #endregion
		
		public NewsOld()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(256) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Body", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string Body
		{
			get
			{
				return this._Body;
			}
			set
			{
				if ((this._Body != value))
				{
					this.OnBodyChanging(value);
					this.SendPropertyChanging();
					this._Body = value;
					this.SendPropertyChanged("Body");
					this.OnBodyChanged();
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
