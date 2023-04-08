document.querySelector("#files").addEventListener("change",(e)=>{
    if(window.File && window.FileReader && window.FileList && window.Blob){
        const files = e.target.files;
        const output = document.querySelector("#result");
        for(let i=0;i<files.length;i++){
            if(!files[i].type.match("image")) continue;
            const picReader = new FileReader();
            picReader.addEventListener("load",function(event){
                const picFile = event.target;
                const div = document.createElement("div");
                div.className="output";
                div.innerHTML=`<img class="thumbnail" src="${picFile.result}" title="${picFile.name}"/>
                <div style="display:flex">
                <button><i class="fa-solid fa-thumbs-up like"></i><span class="like_count"></span></button>
                
                <input type="text" class="comment_input"><button class="comment_button">Comment</button>
                </div>
                <div class="comments"></div>`;
                const likeButton = div.querySelector(".like");
        const likeCount = div.querySelector(".like_count");
        let count = 0;
       
        const commentInput = div.querySelector(".comment_input");
        const commentButton = div.querySelector(".comment_button");
        const comments = div.querySelector(".comments");

        
        let commentIndex = 0;
        let commentList = [];
        commentButton.addEventListener("click", function() {
            const comment = commentInput.value.trim();
  
            if (comment !== "") {
              commentList.push(comment);
              commentInput.value = "";
              updateComments();
            }
          });
          
        function updateComments() {
            comments.innerHTML = "";
  
            for (let j = 0; j < commentList.length; j++) {
              const commentDiv = document.createElement("div");
              commentDiv.innerHTML = `
                <span class="comment_index">${commentIndex + j + 1}.</span>
                <span class="comment_text">${commentList[j]}</span>
              `;
              comments.appendChild(commentDiv);
            }
          }
        likeButton.addEventListener("click", function() {
          count++;
          likeCount.textContent = count;
        });
                output.appendChild(div);
             

            })
            picReader.readAsDataURL(files[i]);
        }

    }
    else{
        alert("Your Browser does not supports the file api")
    }
})
