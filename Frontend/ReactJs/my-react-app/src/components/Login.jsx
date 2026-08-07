export function Login(){
    const [email, setEmail] = useState('');
const [password, setPassword] = useState('');
setEmail('');
setPassword('');
const handleLogin = () => {
    // Perform login logic here, such as sending a request to the server
    console.log('Logging in with email:', email, 'and password:', password);
    if(email === 'Admin' && password === 'Admin123'){
        alert('Login successful!');
    } else {
        alert('Invalid email or password.');
    }
}

 return (<form>
    <div>
        <label>Email </label><input type="text" value={email} onChange={(e) => setEmail(e.target.value)} />
    </div>
    <div>
        <label>Password </label><input type="password" value={password} onChange={(e) => setPassword(e.target.value)} />
    </div>
    <Button onClick={handleLogin}>Login</Button>
 </form>);
 }
