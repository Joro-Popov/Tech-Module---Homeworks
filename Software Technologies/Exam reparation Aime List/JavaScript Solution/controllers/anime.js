const Anime = require('../models/Anime');

module.exports = {
	index: (req, res) => {

		Anime.find().then(anime => {
		    res.render('anime/index', {'animes': anime})
        });
	},
	createGet: (req, res) => {
        res.render('anime/create');
	},
	createPost: (req, res) => {

	    let anime = req.body;
	    Anime.create(anime).then(anime => {
	        res.redirect("/");
        })
	},
	deleteGet: (req, res) => {

	    let animeId = req.params.id;
	    Anime.findById(animeId).then(anime => {
	        if(anime){

	            return res.render('anime/delete', anime);
            }else{

	            res.redirect('/');
            }
        })
	},
	deletePost: (req, res) => {

	    let animeId = req.params.id;
	    Anime.findByIdAndRemove(animeId).then(anime => {
	        res.redirect('/');
        })
	}
};