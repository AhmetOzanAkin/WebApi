namespace Business.Dtos.Response;

public class GetAllBrandResponse
{
    // Kullanıcıya döndüğümüz cevap
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }
}
