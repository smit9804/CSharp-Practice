class Movie{
    public string title;
    public string director;
    private string rating;

    public Movie(string atitle, string adirector, string aRating){
        title = atitle;
        director = adirector;
        Rating = Rating;
    }

    public string Rating{
        get{return rating;}
        set{
            if(value=="G" || value=="PG" || value=="PG-13" || value=="R" || value=="NR"){
                rating = value;
            }
            else{
                rating = "NR";
            }
        }
    }
}