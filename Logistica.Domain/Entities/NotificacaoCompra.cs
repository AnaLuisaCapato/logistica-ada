public class NotificacaoCompra : BaseEntity
{
    public Destinatario Destinatario { get; set; }

    public List<Produto> Produtos { get; set; }
}

