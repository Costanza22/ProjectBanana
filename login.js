document.getElementById("login-form").addEventListener("submit", function(event) {
    event.preventDefault(); // Evita o envio do formulário padrão
  
    var usernameInput = document.getElementById("username").value;
    var passwordInput = document.getElementById("password").value;
  
    // Verifica se o usuário e senha estão corretos
    if (usernameInput === "@22" && passwordInput === "123") {
      window.location.href = "index.html"; // Redireciona para a página "index.html"
    } else {
      alert("Usuário ou senha incorretos. Tente novamente."); // Exibe uma mensagem de erro
    }
  });
  