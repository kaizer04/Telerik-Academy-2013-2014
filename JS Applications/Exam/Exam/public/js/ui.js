var ui = (function () {

	function buildLoginForm() {
		var html =
            '<div id="login-form-holder">' +
				'<form>' +
					'<div id="login-form">' +
						'<label for="tb-login-username">Username: </label>' +
						'<input type="text" id="tb-login-username"><br />' +
						'<label for="tb-login-password">Password: </label>' +
						'<input type="password" id="tb-login-password"><br />' +
						'<button id="btn-login" class="button">Login</button>' +
					'</div>' +
					'<div id="register-form" style="display: none">' +
						'<label for="tb-register-username">Username: </label>' +
						'<input type="text" id="tb-register-username"><br />' +
						'<label for="tb-register-password">Password: </label>' +
						'<input type="password" id="tb-register-password"><br />' +
						'<button id="btn-register" class="button">Register</button>' +
					'</div>' +
					'<a href="#" id="btn-show-login" class="button selected">Login</a>' +
					'<a href="#" id="btn-show-register" class="button">Register</a>' +
				'</form>' +
				'<div id="error-messages"></div>' +
            '</div>';
		return html;
	}

	function buildForum(username) {
		var html = '<span id="user-name">' +
				username +
		'</span>' +
		'<button id="btn-logout">Logout</button><br/>' +
		'<div id="create-messages-holder">' +
			'title: <input type="text" id="tb-create-title" />' +
			'body: <input type="text" id="tb-create-pass" />' +
		'</div>';
		return html;
	}

	
	
	function startMessagesList(messages) {
		var list = '<ul id="messages-list">';
		var msg;
		for (var i = 0; i < messages.length; i += 1) {
			msg = messages[i];
			var item =
				'<li>' +
					'<a href="#" class="message-state-' + msg.state + '">' +
						msg.text +
					'</a>' +
				'</li>';
			list += item;
		}
		list += '</ul>';
		return list;
	}

	function showedMessagesList(messages) {
	    var list = '<ul class="messages-list">';
	    var msg;
	    for (var i = 0; i < messages.length; i += 1) {
	        msg = messages[i];
	        var item =
				'<li>' +
					'<a href="#" class="message-state-' + msg.state + '">' +
						msg.text +
					'</a>' +
				'</li>';
	        list += item;
	    }
	    list += '</ul>';
	    return list;
	}

	return {
	    gameUI: buildForum,
        loginForm: buildLoginForm,
		messagesList: buildMessagesList,
		startMessageList: showedMessagesList
	}

}());