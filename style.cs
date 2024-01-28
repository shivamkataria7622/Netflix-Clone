 @import url('https://fonts.googleapis.com/css2?family=Martel+Sans:wght@200;600&display=swap');

*{
    padding: 0%;
    margin: 0%;
}
body {
    background-color: black;
}
.main{
    background-image: url(assets/images/bg.jpg);
    background-repeat: no-repeat;
    background-size: max(1200px ,100vw);
    height: 90vh;
    position: relative;
}

.main .box{
    height: 90vh;
    width: 100%;
    opacity: 0.44;
    background-color: black;
    position: absolute;
    top: 0%;
}
nav {
    display: flex;
    align-items: center;
    max-width: 60vw;
    height: 62px;
    margin: auto;
    justify-content: space-between;
   

}
nav img {
    color: red;
    width: 114px;
    position: relative;
    z-index: 10;
}
nav button{
    position: relative;
    z-index: 10;
}

.hero {
    height: 92%;
    color: white;
    display: flex;
    justify-content: center;
    align-items: center;
    flex-direction: column;
    position: relative;
    gap: 23px;
    padding: 0 30px   ;
    font-family: 'Martel Sans', sans-serif;    
}
.hero > :nth-child(1){
    text-align: center;
    font-size: 48px;
    font-weight: bolder;
}
.hero > :nth-child(2){
    text-align: center;
    font-size: 24px;
    font-weight: 400px;
}
.hero > :nth-child(3){
    text-align: center;
    font-size: 20px;
    font-weight: 400px;
}

.hero input{
    width: 390px;
    height: 40px;
    background-color: black;
    color: white;
    border-radius: 0.3rem;
}
.hero button{
    position: relative;
    top: 1px;
    width: 173px;
    background-color: red;
    color: white;
    border-radius: 0.3rem;
    height: 41px;
}

.line   {
    height: 9px;
    background-color: grey;
}