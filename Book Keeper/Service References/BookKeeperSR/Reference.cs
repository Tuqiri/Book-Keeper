﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Book_Keeper.BookKeeperSR {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BookModel", Namespace="http://schemas.datacontract.org/2004/07/Book_Keeper_WCF_Service.Models")]
    [System.SerializableAttribute()]
    public partial class BookModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Book_Keeper.BookKeeperSR.AuthorModel[] AuthorsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BookidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StockField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Book_Keeper.BookKeeperSR.AuthorModel[] Authors {
            get {
                return this.AuthorsField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorsField, value) != true)) {
                    this.AuthorsField = value;
                    this.RaisePropertyChanged("Authors");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Bookid {
            get {
                return this.BookidField;
            }
            set {
                if ((this.BookidField.Equals(value) != true)) {
                    this.BookidField = value;
                    this.RaisePropertyChanged("Bookid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Stock {
            get {
                return this.StockField;
            }
            set {
                if ((this.StockField.Equals(value) != true)) {
                    this.StockField = value;
                    this.RaisePropertyChanged("Stock");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuthorModel", Namespace="http://schemas.datacontract.org/2004/07/Book_Keeper_WCF_Service.Models")]
    [System.SerializableAttribute()]
    public partial class AuthorModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AutheridField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Autherid {
            get {
                return this.AutheridField;
            }
            set {
                if ((this.AutheridField.Equals(value) != true)) {
                    this.AutheridField = value;
                    this.RaisePropertyChanged("Autherid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BookKeeperSR.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBooks", ReplyAction="http://tempuri.org/IService1/GetBooksResponse")]
        Book_Keeper.BookKeeperSR.BookModel[] GetBooks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBooks", ReplyAction="http://tempuri.org/IService1/GetBooksResponse")]
        System.Threading.Tasks.Task<Book_Keeper.BookKeeperSR.BookModel[]> GetBooksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAuthors", ReplyAction="http://tempuri.org/IService1/getAuthorsResponse")]
        Book_Keeper.BookKeeperSR.AuthorModel[] getAuthors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAuthors", ReplyAction="http://tempuri.org/IService1/getAuthorsResponse")]
        System.Threading.Tasks.Task<Book_Keeper.BookKeeperSR.AuthorModel[]> getAuthorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBookById", ReplyAction="http://tempuri.org/IService1/GetBookByIdResponse")]
        Book_Keeper.BookKeeperSR.BookModel GetBookById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBookById", ReplyAction="http://tempuri.org/IService1/GetBookByIdResponse")]
        System.Threading.Tasks.Task<Book_Keeper.BookKeeperSR.BookModel> GetBookByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAuthorById", ReplyAction="http://tempuri.org/IService1/GetAuthorByIdResponse")]
        Book_Keeper.BookKeeperSR.AuthorModel GetAuthorById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAuthorById", ReplyAction="http://tempuri.org/IService1/GetAuthorByIdResponse")]
        System.Threading.Tasks.Task<Book_Keeper.BookKeeperSR.AuthorModel> GetAuthorByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddBook", ReplyAction="http://tempuri.org/IService1/AddBookResponse")]
        bool AddBook(Book_Keeper.BookKeeperSR.BookModel book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddBook", ReplyAction="http://tempuri.org/IService1/AddBookResponse")]
        System.Threading.Tasks.Task<bool> AddBookAsync(Book_Keeper.BookKeeperSR.BookModel book);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Book_Keeper.BookKeeperSR.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Book_Keeper.BookKeeperSR.IService1>, Book_Keeper.BookKeeperSR.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Book_Keeper.BookKeeperSR.BookModel[] GetBooks() {
            return base.Channel.GetBooks();
        }
        
        public System.Threading.Tasks.Task<Book_Keeper.BookKeeperSR.BookModel[]> GetBooksAsync() {
            return base.Channel.GetBooksAsync();
        }
        
        public Book_Keeper.BookKeeperSR.AuthorModel[] getAuthors() {
            return base.Channel.getAuthors();
        }
        
        public System.Threading.Tasks.Task<Book_Keeper.BookKeeperSR.AuthorModel[]> getAuthorsAsync() {
            return base.Channel.getAuthorsAsync();
        }
        
        public Book_Keeper.BookKeeperSR.BookModel GetBookById(int id) {
            return base.Channel.GetBookById(id);
        }
        
        public System.Threading.Tasks.Task<Book_Keeper.BookKeeperSR.BookModel> GetBookByIdAsync(int id) {
            return base.Channel.GetBookByIdAsync(id);
        }
        
        public Book_Keeper.BookKeeperSR.AuthorModel GetAuthorById(int id) {
            return base.Channel.GetAuthorById(id);
        }
        
        public System.Threading.Tasks.Task<Book_Keeper.BookKeeperSR.AuthorModel> GetAuthorByIdAsync(int id) {
            return base.Channel.GetAuthorByIdAsync(id);
        }
        
        public bool AddBook(Book_Keeper.BookKeeperSR.BookModel book) {
            return base.Channel.AddBook(book);
        }
        
        public System.Threading.Tasks.Task<bool> AddBookAsync(Book_Keeper.BookKeeperSR.BookModel book) {
            return base.Channel.AddBookAsync(book);
        }
    }
}
