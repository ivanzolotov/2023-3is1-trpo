const registration = document.querySelectorAll('.registration')[0];
const exit = document.querySelectorAll('.exit')[0];

const registrationFunction = function() 
{
	alert('Вы успешно зарегистрировались!');
}

const exitFunction = function() 
{
	alert('Вы успешно вошли в свой аккаунт!');
}

registration.addEventListener('click', registrationFunction);
exit.addEventListener('click', exitFunction);