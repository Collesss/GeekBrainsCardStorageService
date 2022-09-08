namespace GeekBrainsCardStorageService.Repository.Exceptions
{
    public enum ErrorCodeRepositoryEnum : int
    {
        None = 0b0000_0000__0000_0000__0000_0000__0000_0000,
        StringError = 0b0000_0000__0000_0000__0000_0000__1000_0000,
        StingShort = 0b0000_0000__0000_0000__0000_0000__1100_0000,
        StingLong = 0b0000_0000__0000_0000__0000_0000__1010_0000,
        StingNotMatchFormat = 0b0000_0000__0000_0000__0000_0000__1001_0000,
        KeyError = 0b0000_0000__0000_0000__1000_0000__0000_0000,
        KeyAltError = 0b0000_0000__0000_0000__1100_0000__0000_0000,
        KeyForeginError = 0b0000_0000__0000_0000__1010_0000__0000_0000 
    }
}
