﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FocusAppTest2.ServiceReference3 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Member", Namespace="http://schemas.datacontract.org/2004/07/FocusWCF")]
    [System.SerializableAttribute()]
    public partial class Member : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string roleField;
        
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
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string role {
            get {
                return this.roleField;
            }
            set {
                if ((object.ReferenceEquals(this.roleField, value) != true)) {
                    this.roleField = value;
                    this.RaisePropertyChanged("role");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Profile", Namespace="http://schemas.datacontract.org/2004/07/FocusWCF")]
    [System.SerializableAttribute()]
    public partial class Profile : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string addressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> birthdateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string firstnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string lastnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long memberIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> phoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> zipField;
        
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
        public string address {
            get {
                return this.addressField;
            }
            set {
                if ((object.ReferenceEquals(this.addressField, value) != true)) {
                    this.addressField = value;
                    this.RaisePropertyChanged("address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> birthdate {
            get {
                return this.birthdateField;
            }
            set {
                if ((this.birthdateField.Equals(value) != true)) {
                    this.birthdateField = value;
                    this.RaisePropertyChanged("birthdate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string city {
            get {
                return this.cityField;
            }
            set {
                if ((object.ReferenceEquals(this.cityField, value) != true)) {
                    this.cityField = value;
                    this.RaisePropertyChanged("city");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string firstname {
            get {
                return this.firstnameField;
            }
            set {
                if ((object.ReferenceEquals(this.firstnameField, value) != true)) {
                    this.firstnameField = value;
                    this.RaisePropertyChanged("firstname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lastname {
            get {
                return this.lastnameField;
            }
            set {
                if ((object.ReferenceEquals(this.lastnameField, value) != true)) {
                    this.lastnameField = value;
                    this.RaisePropertyChanged("lastname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long memberId {
            get {
                return this.memberIdField;
            }
            set {
                if ((this.memberIdField.Equals(value) != true)) {
                    this.memberIdField = value;
                    this.RaisePropertyChanged("memberId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> phone {
            get {
                return this.phoneField;
            }
            set {
                if ((this.phoneField.Equals(value) != true)) {
                    this.phoneField = value;
                    this.RaisePropertyChanged("phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> zip {
            get {
                return this.zipField;
            }
            set {
                if ((this.zipField.Equals(value) != true)) {
                    this.zipField = value;
                    this.RaisePropertyChanged("zip");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CourseMember", Namespace="http://schemas.datacontract.org/2004/07/FocusWCF")]
    [System.SerializableAttribute()]
    public partial class CourseMember : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int courseIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long memberIdField;
        
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
        public int courseId {
            get {
                return this.courseIdField;
            }
            set {
                if ((this.courseIdField.Equals(value) != true)) {
                    this.courseIdField = value;
                    this.RaisePropertyChanged("courseId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long memberId {
            get {
                return this.memberIdField;
            }
            set {
                if ((this.memberIdField.Equals(value) != true)) {
                    this.memberIdField = value;
                    this.RaisePropertyChanged("memberId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Course", Namespace="http://schemas.datacontract.org/2004/07/FocusWCF")]
    [System.SerializableAttribute()]
    public partial class Course : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int capacityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime enddateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string infoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string locationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int priceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime startdateField;
        
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
        public int capacity {
            get {
                return this.capacityField;
            }
            set {
                if ((this.capacityField.Equals(value) != true)) {
                    this.capacityField = value;
                    this.RaisePropertyChanged("capacity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime enddate {
            get {
                return this.enddateField;
            }
            set {
                if ((this.enddateField.Equals(value) != true)) {
                    this.enddateField = value;
                    this.RaisePropertyChanged("enddate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string info {
            get {
                return this.infoField;
            }
            set {
                if ((object.ReferenceEquals(this.infoField, value) != true)) {
                    this.infoField = value;
                    this.RaisePropertyChanged("info");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string location {
            get {
                return this.locationField;
            }
            set {
                if ((object.ReferenceEquals(this.locationField, value) != true)) {
                    this.locationField = value;
                    this.RaisePropertyChanged("location");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int price {
            get {
                return this.priceField;
            }
            set {
                if ((this.priceField.Equals(value) != true)) {
                    this.priceField = value;
                    this.RaisePropertyChanged("price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime startdate {
            get {
                return this.startdateField;
            }
            set {
                if ((this.startdateField.Equals(value) != true)) {
                    this.startdateField = value;
                    this.RaisePropertyChanged("startdate");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AdminModel", Namespace="http://schemas.datacontract.org/2004/07/FocusWCF")]
    [System.SerializableAttribute()]
    public partial class AdminModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PhoneField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Fname {
            get {
                return this.FnameField;
            }
            set {
                if ((object.ReferenceEquals(this.FnameField, value) != true)) {
                    this.FnameField = value;
                    this.RaisePropertyChanged("Fname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Lname {
            get {
                return this.LnameField;
            }
            set {
                if ((object.ReferenceEquals(this.LnameField, value) != true)) {
                    this.LnameField = value;
                    this.RaisePropertyChanged("Lname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((this.PhoneField.Equals(value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="FacebookMember", Namespace="http://schemas.datacontract.org/2004/07/FocusWCF")]
    [System.SerializableAttribute()]
    public partial class FacebookMember : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string accessTokenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long facebookidField;
        
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
        public string accessToken {
            get {
                return this.accessTokenField;
            }
            set {
                if ((object.ReferenceEquals(this.accessTokenField, value) != true)) {
                    this.accessTokenField = value;
                    this.RaisePropertyChanged("accessToken");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long facebookid {
            get {
                return this.facebookidField;
            }
            set {
                if ((this.facebookidField.Equals(value) != true)) {
                    this.facebookidField = value;
                    this.RaisePropertyChanged("facebookid");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference3.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMembers", ReplyAction="http://tempuri.org/IService1/GetMembersResponse")]
        FocusAppTest2.ServiceReference3.Member[] GetMembers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMembers", ReplyAction="http://tempuri.org/IService1/GetMembersResponse")]
        System.Threading.Tasks.Task<FocusAppTest2.ServiceReference3.Member[]> GetMembersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetProfiles", ReplyAction="http://tempuri.org/IService1/GetProfilesResponse")]
        FocusAppTest2.ServiceReference3.Profile[] GetProfiles();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetProfiles", ReplyAction="http://tempuri.org/IService1/GetProfilesResponse")]
        System.Threading.Tasks.Task<FocusAppTest2.ServiceReference3.Profile[]> GetProfilesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCourseMembers", ReplyAction="http://tempuri.org/IService1/GetCourseMembersResponse")]
        FocusAppTest2.ServiceReference3.CourseMember[] GetCourseMembers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCourseMembers", ReplyAction="http://tempuri.org/IService1/GetCourseMembersResponse")]
        System.Threading.Tasks.Task<FocusAppTest2.ServiceReference3.CourseMember[]> GetCourseMembersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCourses", ReplyAction="http://tempuri.org/IService1/GetCoursesResponse")]
        FocusAppTest2.ServiceReference3.Course[] GetCourses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCourses", ReplyAction="http://tempuri.org/IService1/GetCoursesResponse")]
        System.Threading.Tasks.Task<FocusAppTest2.ServiceReference3.Course[]> GetCoursesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/JoinCourse", ReplyAction="http://tempuri.org/IService1/JoinCourseResponse")]
        bool JoinCourse(long memberId, int courseId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/JoinCourse", ReplyAction="http://tempuri.org/IService1/JoinCourseResponse")]
        System.Threading.Tasks.Task<bool> JoinCourseAsync(long memberId, int courseId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CancelCourse", ReplyAction="http://tempuri.org/IService1/CancelCourseResponse")]
        bool CancelCourse(long memberId, int courseId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CancelCourse", ReplyAction="http://tempuri.org/IService1/CancelCourseResponse")]
        System.Threading.Tasks.Task<bool> CancelCourseAsync(long memberId, int courseId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetProfile", ReplyAction="http://tempuri.org/IService1/GetProfileResponse")]
        FocusAppTest2.ServiceReference3.Profile GetProfile(long memberId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetProfile", ReplyAction="http://tempuri.org/IService1/GetProfileResponse")]
        System.Threading.Tasks.Task<FocusAppTest2.ServiceReference3.Profile> GetProfileAsync(long memberId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateProfile", ReplyAction="http://tempuri.org/IService1/UpdateProfileResponse")]
        bool UpdateProfile(long memberId, string address, int phone, string birthdate, string fname, string lname, int zip, string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateProfile", ReplyAction="http://tempuri.org/IService1/UpdateProfileResponse")]
        System.Threading.Tasks.Task<bool> UpdateProfileAsync(long memberId, string address, int phone, string birthdate, string fname, string lname, int zip, string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAdmin", ReplyAction="http://tempuri.org/IService1/GetAdminResponse")]
        FocusAppTest2.ServiceReference3.AdminModel[] GetAdmin();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAdmin", ReplyAction="http://tempuri.org/IService1/GetAdminResponse")]
        System.Threading.Tasks.Task<FocusAppTest2.ServiceReference3.AdminModel[]> GetAdminAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddMember", ReplyAction="http://tempuri.org/IService1/AddMemberResponse")]
        FocusAppTest2.ServiceReference3.Member AddMember(string email, string passwordhash);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddMember", ReplyAction="http://tempuri.org/IService1/AddMemberResponse")]
        System.Threading.Tasks.Task<FocusAppTest2.ServiceReference3.Member> AddMemberAsync(string email, string passwordhash);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetPasswordForMember", ReplyAction="http://tempuri.org/IService1/SetPasswordForMemberResponse")]
        void SetPasswordForMember(int memberId, string passwordhash);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetPasswordForMember", ReplyAction="http://tempuri.org/IService1/SetPasswordForMemberResponse")]
        System.Threading.Tasks.Task SetPasswordForMemberAsync(int memberId, string passwordhash);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddFacebookMember", ReplyAction="http://tempuri.org/IService1/AddFacebookMemberResponse")]
        FocusAppTest2.ServiceReference3.FacebookMember AddFacebookMember(long facebookid, string accessToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddFacebookMember", ReplyAction="http://tempuri.org/IService1/AddFacebookMemberResponse")]
        System.Threading.Tasks.Task<FocusAppTest2.ServiceReference3.FacebookMember> AddFacebookMemberAsync(long facebookid, string accessToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateAccessToken", ReplyAction="http://tempuri.org/IService1/UpdateAccessTokenResponse")]
        bool UpdateAccessToken(long facebookid, string accessToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateAccessToken", ReplyAction="http://tempuri.org/IService1/UpdateAccessTokenResponse")]
        System.Threading.Tasks.Task<bool> UpdateAccessTokenAsync(long facebookid, string accessToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetFacebookMembers", ReplyAction="http://tempuri.org/IService1/GetFacebookMembersResponse")]
        FocusAppTest2.ServiceReference3.FacebookMember[] GetFacebookMembers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetFacebookMembers", ReplyAction="http://tempuri.org/IService1/GetFacebookMembersResponse")]
        System.Threading.Tasks.Task<FocusAppTest2.ServiceReference3.FacebookMember[]> GetFacebookMembersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : FocusAppTest2.ServiceReference3.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<FocusAppTest2.ServiceReference3.IService1>, FocusAppTest2.ServiceReference3.IService1 {
        
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
        
        public FocusAppTest2.ServiceReference3.Member[] GetMembers() {
            return base.Channel.GetMembers();
        }
        
        public System.Threading.Tasks.Task<FocusAppTest2.ServiceReference3.Member[]> GetMembersAsync() {
            return base.Channel.GetMembersAsync();
        }
        
        public FocusAppTest2.ServiceReference3.Profile[] GetProfiles() {
            return base.Channel.GetProfiles();
        }
        
        public System.Threading.Tasks.Task<FocusAppTest2.ServiceReference3.Profile[]> GetProfilesAsync() {
            return base.Channel.GetProfilesAsync();
        }
        
        public FocusAppTest2.ServiceReference3.CourseMember[] GetCourseMembers() {
            return base.Channel.GetCourseMembers();
        }
        
        public System.Threading.Tasks.Task<FocusAppTest2.ServiceReference3.CourseMember[]> GetCourseMembersAsync() {
            return base.Channel.GetCourseMembersAsync();
        }
        
        public FocusAppTest2.ServiceReference3.Course[] GetCourses() {
            return base.Channel.GetCourses();
        }
        
        public System.Threading.Tasks.Task<FocusAppTest2.ServiceReference3.Course[]> GetCoursesAsync() {
            return base.Channel.GetCoursesAsync();
        }
        
        public bool JoinCourse(long memberId, int courseId) {
            return base.Channel.JoinCourse(memberId, courseId);
        }
        
        public System.Threading.Tasks.Task<bool> JoinCourseAsync(long memberId, int courseId) {
            return base.Channel.JoinCourseAsync(memberId, courseId);
        }
        
        public bool CancelCourse(long memberId, int courseId) {
            return base.Channel.CancelCourse(memberId, courseId);
        }
        
        public System.Threading.Tasks.Task<bool> CancelCourseAsync(long memberId, int courseId) {
            return base.Channel.CancelCourseAsync(memberId, courseId);
        }
        
        public FocusAppTest2.ServiceReference3.Profile GetProfile(long memberId) {
            return base.Channel.GetProfile(memberId);
        }
        
        public System.Threading.Tasks.Task<FocusAppTest2.ServiceReference3.Profile> GetProfileAsync(long memberId) {
            return base.Channel.GetProfileAsync(memberId);
        }
        
        public bool UpdateProfile(long memberId, string address, int phone, string birthdate, string fname, string lname, int zip, string city) {
            return base.Channel.UpdateProfile(memberId, address, phone, birthdate, fname, lname, zip, city);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateProfileAsync(long memberId, string address, int phone, string birthdate, string fname, string lname, int zip, string city) {
            return base.Channel.UpdateProfileAsync(memberId, address, phone, birthdate, fname, lname, zip, city);
        }
        
        public FocusAppTest2.ServiceReference3.AdminModel[] GetAdmin() {
            return base.Channel.GetAdmin();
        }
        
        public System.Threading.Tasks.Task<FocusAppTest2.ServiceReference3.AdminModel[]> GetAdminAsync() {
            return base.Channel.GetAdminAsync();
        }
        
        public FocusAppTest2.ServiceReference3.Member AddMember(string email, string passwordhash) {
            return base.Channel.AddMember(email, passwordhash);
        }
        
        public System.Threading.Tasks.Task<FocusAppTest2.ServiceReference3.Member> AddMemberAsync(string email, string passwordhash) {
            return base.Channel.AddMemberAsync(email, passwordhash);
        }
        
        public void SetPasswordForMember(int memberId, string passwordhash) {
            base.Channel.SetPasswordForMember(memberId, passwordhash);
        }
        
        public System.Threading.Tasks.Task SetPasswordForMemberAsync(int memberId, string passwordhash) {
            return base.Channel.SetPasswordForMemberAsync(memberId, passwordhash);
        }
        
        public FocusAppTest2.ServiceReference3.FacebookMember AddFacebookMember(long facebookid, string accessToken) {
            return base.Channel.AddFacebookMember(facebookid, accessToken);
        }
        
        public System.Threading.Tasks.Task<FocusAppTest2.ServiceReference3.FacebookMember> AddFacebookMemberAsync(long facebookid, string accessToken) {
            return base.Channel.AddFacebookMemberAsync(facebookid, accessToken);
        }
        
        public bool UpdateAccessToken(long facebookid, string accessToken) {
            return base.Channel.UpdateAccessToken(facebookid, accessToken);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateAccessTokenAsync(long facebookid, string accessToken) {
            return base.Channel.UpdateAccessTokenAsync(facebookid, accessToken);
        }
        
        public FocusAppTest2.ServiceReference3.FacebookMember[] GetFacebookMembers() {
            return base.Channel.GetFacebookMembers();
        }
        
        public System.Threading.Tasks.Task<FocusAppTest2.ServiceReference3.FacebookMember[]> GetFacebookMembersAsync() {
            return base.Channel.GetFacebookMembersAsync();
        }
    }
}
