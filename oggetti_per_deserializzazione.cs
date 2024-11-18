class Treno
{
    public string _id, n, p, rp, a, ra, pr, dl, c, oo, od, cn, sep, sea, oaz, opz, oae, ope, sub; //rispettivamente id treno, numero treno, nome stazione partenza, ritardo partenza, nome stazione arrivo, ritardo arrivo, provvedimenti (soppressioni), deviazioni o limitazioni (descrittivo), categoria, origine iniziale (in caso di variazioni), destinazione iniziale (in caso di variazioni), cambi numero, stazione estera di partenza, stazione estera di arrivo, ora arrivo originale (in caso di variazioni), ora partenza originale (in caso di variazioni), ora arrivo estero, ora partenza estero, sottocategoria (es. FR).  
    public long op, oa; //ora partenza, ora arrivo, in timestamp in secondi
    public List<FermataTreno> fr;
}
class FermataTreno
{
    public string n, ra, rp; //nome, ritardo arrivo, ritardo partenza
    public long oa, op; //ora arrivo, ora partenza, timestamp in secondi
}
class AvvisiGiorno
{
    public string _id { get; set; }
    public List<AvvisoTI> avvisi { get; set; }
}
class Riassunto
{
    public int treniMonitorati { get; set; }
    public int treniRegolari { get; set; }
    public int treniCancellati { get; set; }
    public int treniRiprogrammati { get; set; }
    public int partenzaInOrario { get; set; }
    public int partenzaRitardo { get; set; }
    public int arrivoAnticipo { get; set; }
    public int arrivoInOrario { get; set; }
    public int arrivoInRitardo { get; set; }
    public string trenoPeggiore { get; set; }
    public int ritardoPartenzaTrenoPeggiore { get; set; }
    public int ritardoArrivoTrenoPeggiore { get; set; }
    public int numIC { get; set; }
    public int numES { get; set; }
    public int numEC { get; set; }
    public int numEN { get; set; }
    public int numREG { get; set; }
    public int numNC { get; set; }
    public int treniCircolati { get; set; }
    public int ritardoAccumulato { get; set; }
    public int anticipoAccumulato { get; set; }
    public string dataAggiornamento { get; set; }
    public string circolazione { get; set; }
}
class Giorno
{
    public string giorno { get; set; }
    public int timeZone { get; set; }
    public Riassunto riassunto { get; set; }
    public List<AvvisoRFI> avvisiRFI { get; set; }
    public List<AvvisoTI> avvisiTI { get; set; }
    public List<Treno> treni { get; set; }

}
class AvvisoRFI
{
    public string titolo { get; set; }
    public string data { get; set; }
    public string corpo { get; set; }
    public string link { get; set; }
}
class AvvisoTI
{
    public string titolo { get; set; }
    public string data { get; set; }
    public string corpo { get; set; }
    public string ordine { get; set; }
}
