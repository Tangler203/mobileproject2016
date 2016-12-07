# mobileproject2016

This is an app I made for my Mobile applications development 3 course.

## Overview

This app is movie finder app that uses the [OMDI api](https://www.omdbapi.com) to search for films on [IMDB](www.imdb.com).

OMDB is an api webservice that searches IMDB and returns the result in either Json or Xml.

OMDB uses http://www.omdbapi.com/? to search for films and returns (by default) a Json object containing information about the film including the title, a plot summary, the year of release and the actors that starred in it.


#### Example

To search for the film Finding Dory you the http://www.omdbapi.com/?t=Finding+Dory

This returns the following Json object:

>{"Title":"Finding Dory","Year":"2016","Rated":"PG","Released":"17 Jun 2016","Runtime":"97 min","Genre":"Animation, Adventure, Comedy","Director":"Andrew Stanton, Angus MacLane","Writer":"Andrew Stanton (original story by), Andrew Stanton (screenplay), Victoria Strouse (screenplay), Bob Peterson (additional screenplay material by), Angus MacLane (additional story material by)","Actors":"Ellen DeGeneres, Albert Brooks, Ed O'Neill, Kaitlin Olson","Plot":"The friendly but forgetful blue tang fish begins a search for her long-lost parents, and everyone learns a few things about the real meaning of family along the way.","Language":"English, Indonesian","Country":"USA","Awards":"2 wins & 2 nominations.","Poster":"https://images-na.ssl-images-amazon.com/images/M/MV5BNzg4MjM2NDQ4MV5BMl5BanBnXkFtZTgwMzk3MTgyODE@._V1_SX300.jpg","Metascore":"77","imdbRating":"7.6","imdbVotes":"92,723","imdbID":"tt2277860","Type":"movie","Response":"True"}

My app asks for the name of the film and parses the json object returning the title, year, runtime, actors, directors and plot making it easier for users
