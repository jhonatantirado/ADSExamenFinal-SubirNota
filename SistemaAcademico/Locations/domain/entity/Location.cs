namespace Locations.Domain{

    using Common.Application;
    public class Location
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string CountryISOCode { get; set; }
        public string UNLocCode { get; set; }
        public bool IsActive { get; set; }

        public Location(){

        }
        public bool hasIdentity(){
            return !string.IsNullOrWhiteSpace(this.UNLocCode);
        }

        public bool hasName(){
            return !string.IsNullOrWhiteSpace(this.Name);
        }

        public bool hasValidCountry(){
            if (string.IsNullOrWhiteSpace(this.CountryISOCode) || 
            (string.IsNullOrWhiteSpace(this.UNLocCode))|| 
            (this.UNLocCode.Length < 2))
                return false;
            else{
                return this.CountryISOCode == this.UNLocCode.Substring(0,2);
            }
        }

        public void activateLocation(){
            if (!this.IsActive) this.IsActive=true;
        }

        public void deactivateLocation(){
            if (this.IsActive) this.IsActive=false;
        }

        private Notification validateForSave(){
            Notification notification = new Notification();
            if (!this.hasIdentity()){
                notification.addError("The location doesn´t have UNLocCode");
            }
            if (!this.hasName()){
                notification.addError("The location doesn´t have a name");
            }
            if (!this.hasValidCountry()){
                notification.addError("The country ISO code doesn´t match the UNLocCode");
            }
            return notification;
        }
    }
}