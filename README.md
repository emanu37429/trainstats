# trainstats

Spiegazione campi dei file JSON

      "_id": "51-1704097020-RE9NT0RPU1NPTEE=",  //id composto da {numero treno}-{ora partenza in timestamp}-{stazione partenza in base64}
      
      "n": "51", //numero treno
      
      "p": "DOMODOSSOLA", //nome stazione partenza
      
      "rp": "4", // ritardo partenza - se X è soppresso
      
      "a": "MILANO CENTRALE", //nome stazione arrivo
      
      "ra": "10", // ritardo arrivo - se X è soppresso
      
      "c": "EC", //categoria treno
      
      "sep": "BASEL SBB", //stazione estera di partenza (in senso inverso, "sea" > stazione estera di arrivo)
      
      "ope": "06:28:00", //ora di partenza dall'estero (in senso inverso, "oae" > ora arrivo alla destinazione estera) 
      
      "op": 1704097020, //ora di partenza
      
      "oa": 1704102000, //ora di arrivo
      
      "fr": //array di fermate (se vuoto, il treno è soppresso e non è stato possibile recuperare l'elenco fermate basandosi sui treni precedenti)
      
            "n": "DOMODOSSOLA", //nome fermata
            
            "ra": "2", //ritardo arrivo - se N è non presente (es. stazione di origine), se S la fermata è soppressa, se n.d. è non rilevato
            
            "rp": "4", //ritardo partenza - se N è non presente (es. stazione di arrivo), se S la fermata è soppressa, se n.d. è non rilevato
            
            "oa": 0, //ora arrivo, quando è zero è perché stazione di partenza
            
            "op": 1704097020 //ora partenza, quando è zero è perché stazione di arrivo



Altre occorrenze:

      "sub": "FR" //le Frecce sono indicate come sottocategoria (in origine la categoria era "ES*" e la sottocategoria "FR", "FB" o "FA". In seguito la categoria è stata rimossa e viene indicata solo la sottocategoria. FA sta per Frecciargento, FB per FrecciaBianca, FR per FrecciaRossa)
      
      "cn": "2378,VOGHERA" //cambi numero in formato {nuovo numero},{stazione di cambio numero}. Se il treno cambia numero più volte, i vari cambi sono separati da punto e virgola
      
      "dl": "Treno cancellato da TELESE CERRETO a ISERNIA. Il treno oggi arriva a AMOROSI MELIZZANO." //dettagli su deviazioni o limitazioni di percorso


Altri dettagli:

il timestamp è in secondi

i ritardi sono in minuti
