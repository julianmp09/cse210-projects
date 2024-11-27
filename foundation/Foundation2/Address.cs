public class Address
{
    // Private attributes
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    // Constructor
    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    // Getter methods
    public string GetStreetAddress() => _streetAddress;
    public string GetCity() => _city;
    public string GetStateOrProvince() => _stateOrProvince;
    public string GetCountry() => _country;

    // Method to verify if the address is in the USA.
    public bool IsInUS() => _country.ToLower() == "united states";

    // Method to return the full address as a string
    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateOrProvince}\n{_country}";
    }
}
