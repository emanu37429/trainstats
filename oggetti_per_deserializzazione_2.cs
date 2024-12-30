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
    public int treniMonitorati, treniRegolari, treniCancellati, treniRiprogrammati;
    public int partenzaInOrario, partenzaRitardo;
    public int arrivoAnticipo, arrivoInOrario, arrivoInRitardo;
    public string trenoPeggiore;
    public int ritardoPartenzaTrenoPeggiore, ritardoArrivoTrenoPeggiore;
    public int numIC, numES, numEC, numEN, numREG, numNC;
    public int treniCircolati, ritardoGenerale, ritardoGeneraleEsclAnticipi, AnticipoGenerale;
    public int ritardoFrecce, numeroFrecceNC, ritardoInterCity, numeroInterCityNC, ritardoRegionali, numeroRegionaliNC;
    public string dataAggiornamento;
    public string circolazione;
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
